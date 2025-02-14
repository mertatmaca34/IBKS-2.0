using System;
using System.IO;

namespace Core.Utilities.TempLogs
{
    public static class TempLog
    {
        private static readonly object _lock = new();

        public static void Write(string metin)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "tempLogs.txt";
                string fullPath = Path.Combine(desktopPath, fileName);

                lock (_lock)
                {
                    using (var stream = new FileStream(fullPath, FileMode.Append, FileAccess.Write, FileShare.Read))
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(metin);
                    }
                }
            }
            catch (IOException ex)
            {
                // Burada istersen başka bir fallback log mekanizması kurabilirsin
                Console.WriteLine($"TempLog yazarken hata: {ex.Message}");
            }
        }
    }
}
