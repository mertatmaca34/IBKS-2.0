using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.TempLogs;
using DataAccess.Concrete.Contexts;
using ibks.Configuration;
using ibks.DependencyResolvers.Autofac;
using ibks.Forms;
using ibks.Mapping;
using ibks.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Authrozation;
using WebAPI.Services;

namespace ibks
{
    public static class Program
    {
        static readonly Mutex mutex = new(true, "{8D9DFE3E-799B-4F97-BF2D-59DE63F5F087}");

        [STAThread]
        static void Main(string[] args)
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {   
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                var host = CreateHostBuilder(args).Build();

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;

                    services.GetRequiredService<GlobalExceptionHandler>();

                    var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();

                    context.Database.EnsureCreated();

                    Application.EnableVisualStyles();

                    Application.Run(services.GetRequiredService<Main>());
                }
            }
            else
            {
                MessageBox.Show("Uygulama zaten çalışıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAndUseLogging()
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
                services.AddSingleton<GlobalExceptionHandler>();
                services.AddHttpClient("ExternalApi", client =>
                {
                    client.Timeout = TimeSpan.FromSeconds(30);
                });
                services.AddAutoMapper(typeof(SendDataMappingProfile).Assembly);
                services.AddScoped<IApiHttpClientFactory, ApiHttpClientFactory>();
            });
    }
}
