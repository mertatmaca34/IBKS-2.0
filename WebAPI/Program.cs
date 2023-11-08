using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using WebAPI.Authrozation;
using WebAPI.Middlewares;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var host = CreateHostBuilder(args).Build();

            builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ISampleService, SampleManager>();
            builder.Services.AddScoped<ISampleDal, EfSampleDal>();
            builder.Services.AddScoped<IPlcService, PlcManager>();
            builder.Services.AddScoped<IPlcDal, EfPlcDal>();
            builder.Services.AddScoped<ISendDataService, SendDataManager>();
            builder.Services.AddScoped<ISendDataDal, EfSendDataDal>();
            builder.Services.AddScoped<ICalibrationDal, EfCalibrationDal>();
            builder.Services.AddScoped<ICalibrationService, CalibrationManager>();

            //builder.Services.AddDbContext<IBKSContext>(p =>
            //{
            //    var conn = builder.Configuration.GetConnectionString("SqlServer");
            //    p.UseSqlServer(conn);
            //});

            var app = builder.Build();


            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseMiddleware<BasicAuthMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());
                builder.RegisterModule(new AutofacApiModule());
            })
            .ConfigureServices((hostContext, services) =>
            {
                //services.AddDbContext<IBKSContext>(options=> options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DataAccess.Contexts.IBKSContext;Trusted_Connection=True;MultipleActiveResultSets=true"));
            });
    }
}