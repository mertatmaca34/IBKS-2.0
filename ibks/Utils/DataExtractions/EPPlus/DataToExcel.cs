using OfficeOpenXml;

namespace ibks.Utils.DataExtractions.EPPlus
{
    public static class DataToExcel
    {
        public static void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                try
                {
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridView.Columns[col].HeaderText;
                    }

                    // Verileri ekleyin
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            object cellValue = dataGridView.Rows[row].Cells[col].Value;
                            if (cellValue != null)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = cellValue.ToString();
                            }
                            else
                            {
                                worksheet.Cells[row + 2, col + 1].Value = ""; // Boş değerler için
                            }
                        }
                    }

                    package.Save();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

}
