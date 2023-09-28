namespace Core.Utilities
{
    public static class TempLog
    {
        public static void Write(string metin)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string fileName = "tempLogs.txt";

            string fullPath = Path.Combine(desktopPath, fileName);


            using (StreamWriter writer = File.AppendText(fullPath))
            {
                writer.WriteLine(metin);
            }
        }
    }
}
