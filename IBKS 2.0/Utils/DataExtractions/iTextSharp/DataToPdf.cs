using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ibks.Utils.DataExtractions.iTextSharp
{
    public static class DataToPdf
    {
        public static void ExportToPdf(DataGridView dataGridView, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                var pageSize = PageSize.A4.Rotate();

                var document = new Document(pageSize, 10f, 10f, 10f, 10f);
                var pdfWriter = PdfWriter.GetInstance(document, stream);
                document.Open();

                PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    pdfTable.AddCell(dataGridView.Columns[col].HeaderText);
                }

                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        pdfTable.AddCell(dataGridView.Rows[row].Cells[col].Value.ToString());
                    }
                }

                document.Add(pdfTable);
                document.Close();
            }
        }
    }
}
