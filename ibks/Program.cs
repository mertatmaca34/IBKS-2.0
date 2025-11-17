using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.TempLogs;
using DataAccess.Concrete.Contexts;
using ibks.DependencyResolvers.Autofac;
using ibks.Forms;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using WebAPI.Authrozation;
using WebAPI.Services;
using Core.Utilities.TempLogs;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Authrozation;
using WebAPI.Services;

namespace ibks
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static readonly Mutex mutex = new(true, "{8D9DFE3E-799B-4F97-BF2D-59DE63F5F087}");

        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
                    TempLog.Write($"{DateTime.Now}: [UnhandledException] {e.ExceptionObject}");
                TaskScheduler.UnobservedTaskException += (sender, e) =>
                {
                    TempLog.Write($"{DateTime.Now}: [UnobservedTaskException] {e.Exception}");
                    e.SetObserved();
                };
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += (sender, e) =>
                    TempLog.Write($"{DateTime.Now}: [ThreadException] {e.Exception}");

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                var host = CreateHostBuilder(args).Build();

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;

                    var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();

                    try
                    {
                        if (!context.Database.CanConnect())
                        {
                            MessageBox.Show("Veritabanına bağlanılamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veritabanına bağlanırken hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    context.Database.EnsureCreated();

                    Application.EnableVisualStyles();

                    try
                    {
                        Application.Run(services.GetRequiredService<Main>());
                    }
                    catch (Exception ex)
                    {
                        TempLog.Write($"{DateTime.Now}: [ApplicationRun] {ex}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Uygulama zaten çalışıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());
                builder.RegisterModule(new AutofacApiModule());
                builder.RegisterModule(new AutofacViewModule());
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddMemoryCache();

                services.AddHttpClient("ExternalApi", client =>
                {
                    client.Timeout = TimeSpan.FromSeconds(30);
                });

                services.AddScoped<IApiHttpClientFactory, ApiHttpClientFactory>();
            });
    }
}
