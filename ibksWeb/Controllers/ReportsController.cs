using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using OfficeOpenXml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace ibksWeb.Controllers;

public class ReportsController : BaseController
{
    private readonly ISendDataService _sendDataService;
    private readonly ICalibrationService _calibrationService;
    private readonly ISampleService _sampleService;

    public ReportsController(ISendDataService sendDataService, ICalibrationService calibrationService, ISampleService sampleService)
    {
        _sendDataService = sendDataService;
        _calibrationService = calibrationService;
        _sampleService = sampleService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GetReport(string reportType, DateTime startDate, DateTime endDate, string sortOrder)
    {
        var reportData = GetReportData(reportType, startDate, endDate, sortOrder);
        return PartialView("_ReportTable", reportData);
    }

    private List<object> GetReportData(string reportType, DateTime startDate, DateTime endDate, string sortOrder)
    {
        List<object> reportData = new List<object>();

        if (reportType == "InstantData")
        {
            var query = _sendDataService.GetAll().Data
                .Where(d => d.Readtime >= startDate && d.Readtime <= endDate);

            reportData = ApplySorting(query, sortOrder).ToList<object>();
        }
        else if (reportType == "CalibrationData")
        {
            var query = _calibrationService.GetAll().Data
                .Where(d => d.TimeStamp >= startDate && d.TimeStamp <= endDate);

            reportData = ApplySorting(query, sortOrder).ToList<object>();
        }
        else if (reportType == "SampleData")
        {
            var query = _sampleService.GetAll().Data
                .Where(d => d.DateTime >= startDate && d.DateTime <= endDate);

            reportData = ApplySorting(query, sortOrder).ToList<object>();
        }

        return reportData;
    }

    private IEnumerable<T> ApplySorting<T>(IEnumerable<T> query, string sortOrder) where T : class
    {
        return sortOrder == "Artan"
            ? query.OrderBy(d => d.GetType().GetProperty("Readtime")?.GetValue(d, null))
            : query.OrderByDescending(d => d.GetType().GetProperty("Readtime")?.GetValue(d, null));
    }

    [HttpPost]
    public IActionResult DownloadExcel(string reportType, DateTime startDate, DateTime endDate)
    {
        var reportData = GetReportData(reportType, startDate, endDate, "Artan");

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Rapor");
            // Başlıklar (webdeki ile aynı sütunlar)
            worksheet.Cells[1, 1].Value = "Tarih";
            worksheet.Cells[1, 2].Value = "Akış Hızı";
            worksheet.Cells[1, 3].Value = "AKM";
            worksheet.Cells[1, 4].Value = "Çözünmüş Oksijen";
            worksheet.Cells[1, 5].Value = "Debi";
            worksheet.Cells[1, 6].Value = "Deşarj Debi";
            worksheet.Cells[1, 7].Value = "Harici Debi";
            worksheet.Cells[1, 8].Value = "Harici Debi2";
            worksheet.Cells[1, 9].Value = "KOi";
            worksheet.Cells[1, 10].Value = "pH";
            worksheet.Cells[1, 11].Value = "Sıcaklık";
            worksheet.Cells[1, 12].Value = "İletkenlik";
            worksheet.Cells[1, 13].Value = "Durum";
            worksheet.Cells[1, 14].Value = "API";

            int row = 2;
            foreach (var item in reportData)
            {
                var data = (dynamic)item;
                worksheet.Cells[row, 1].Value = data.Readtime.ToString("dd.MM.yyyy HH:mm:ss");
                worksheet.Cells[row, 2].Value = data.AkisHizi;
                worksheet.Cells[row, 3].Value = data.AKM;
                worksheet.Cells[row, 4].Value = data.CozunmusOksijen;
                worksheet.Cells[row, 5].Value = data.Debi;
                worksheet.Cells[row, 6].Value = data.DesarjDebi;
                worksheet.Cells[row, 7].Value = data.HariciDebi;
                worksheet.Cells[row, 8].Value = data.HariciDebi2;
                worksheet.Cells[row, 9].Value = data.KOi;
                worksheet.Cells[row, 10].Value = data.pH;
                worksheet.Cells[row, 11].Value = data.Sicaklik;
                worksheet.Cells[row, 12].Value = data.Iletkenlik;
                worksheet.Cells[row, 13].Value = data.IsSent ? "Geçerli" : "Geçersiz";
                worksheet.Cells[row, 14].Value = data.IsSent;
                row++;
            }

            var stream = new MemoryStream();
            package.SaveAs(stream);
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Rapor.xlsx");
        }
    }


    [HttpPost]
    public IActionResult DownloadPdf(string reportType, DateTime startDate, DateTime endDate)
    {
        var reportData = GetReportData(reportType, startDate, endDate, "Artan");

        using (MemoryStream stream = new MemoryStream())
        {
            Document document = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(document, stream);
            document.Open();

            Font fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            document.Add(new Paragraph("Rapor", fontHeader));
            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(14);
            table.AddCell(new Phrase("Tarih", fontHeader));
            table.AddCell(new Phrase("Akış Hızı", fontHeader));
            table.AddCell(new Phrase("AKM", fontHeader));
            table.AddCell(new Phrase("Çözünmüş Oksijen", fontHeader));
            table.AddCell(new Phrase("Debi", fontHeader));
            table.AddCell(new Phrase("Deşarj Debi", fontHeader));
            table.AddCell(new Phrase("Harici Debi", fontHeader));
            table.AddCell(new Phrase("Harici Debi2", fontHeader));
            table.AddCell(new Phrase("KOi", fontHeader));
            table.AddCell(new Phrase("pH", fontHeader));
            table.AddCell(new Phrase("Sıcaklık", fontHeader));
            table.AddCell(new Phrase("İletkenlik", fontHeader));
            table.AddCell(new Phrase("Durum", fontHeader));
            table.AddCell(new Phrase("API", fontHeader));

            foreach (var item in reportData)
            {
                var data = (dynamic)item;
                table.AddCell(new Phrase(data.Readtime.ToString("dd.MM.yyyy HH:mm:ss"), fontNormal));
                table.AddCell(new Phrase(data.AkisHizi.ToString(), fontNormal));
                table.AddCell(new Phrase(data.AKM.ToString(), fontNormal));
                table.AddCell(new Phrase(data.CozunmusOksijen.ToString(), fontNormal));
                table.AddCell(new Phrase(data.Debi.ToString(), fontNormal));
                table.AddCell(new Phrase(data.DesarjDebi.ToString(), fontNormal));
                table.AddCell(new Phrase(data.HariciDebi.ToString(), fontNormal));
                table.AddCell(new Phrase(data.HariciDebi2.ToString(), fontNormal));
                table.AddCell(new Phrase(data.KOi.ToString(), fontNormal));
                table.AddCell(new Phrase(data.pH.ToString(), fontNormal));
                table.AddCell(new Phrase(data.Sicaklik.ToString(), fontNormal));
                table.AddCell(new Phrase(data.Iletkenlik.ToString(), fontNormal));
                table.AddCell(new Phrase(data.IsSent ? "Geçerli" : "Geçersiz", fontNormal));
                table.AddCell(new Phrase(data.IsSent.ToString(), fontNormal));
            }

            document.Add(table);
            document.Close();

            byte[] pdfBytes = stream.ToArray();
            return File(pdfBytes, "application/pdf", "Rapor.pdf");
        }
    }
}
