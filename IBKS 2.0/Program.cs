using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using IBKS_2._0.DependencyResolvers.Autofac;
using IBKS_2._0.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;

namespace IBKS_2._0
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                Application.EnableVisualStyles();

                Application.Run(services.GetRequiredService<Main>());
            }
        }
        public static void ConfigureContainer(ContainerBuilder builder)
        {
            // Autofac modülleri burada kaydedilir.
            builder.RegisterModule(new AutofacApiModule());
            // Diðer modüller de burada kaydedilebilir.
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
                //services.AddDbContext<IBKSContext>(options=> options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DataAccess.Contexts.IBKSContext;Trusted_Connection=True;MultipleActiveResultSets=true"));
            });
    }
}
