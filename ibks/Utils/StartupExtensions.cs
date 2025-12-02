using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibks.Utils;
public static class StartupExtensions
{
    public static IHostBuilder ConfigureAndUseLogging(this IHostBuilder host)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string logsDirectory = Path.Combine(desktopPath, "logs");

        Directory.CreateDirectory(logsDirectory);

        string fileName = $"{DateTime.Now:yyyy-MM-dd}.txt";

        string fullPath = Path.Combine(logsDirectory, fileName);

        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(fullPath)
            .CreateLogger();

        return host.UseSerilog();
    }
}
