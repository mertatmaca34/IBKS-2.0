using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using DataAccess.Concrete.Contexts;
using ibks.DependencyResolvers.Autofac;
using ibks.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;

namespace ibks
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static Mutex mutex = new Mutex(true, "{8D9DFE3E-799B-4F97-BF2D-59DE63F5F087}");

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

                    var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();

                    //context.Database.Migrate();

                    context.Database.EnsureCreated();

                    Application.EnableVisualStyles();

                    Application.Run(services.GetRequiredService<Main>());
                }
            }
            else
            {
                MessageBox.Show("Uygulama zaten çalýþýyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //services.AddDbContext<IBKSContext>(options=> options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DataAccess.Contexts.IBKSContext;Trusted_Connection=True;MultipleActiveResultSets=true"));
            });
    }
}
