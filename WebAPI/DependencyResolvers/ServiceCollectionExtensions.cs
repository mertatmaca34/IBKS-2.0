using Microsoft.Extensions.DependencyInjection;
using WebAPI.Abstract;
using WebAPI.Controllers;
using WebAPI.Services;

namespace WebAPI.DependencyResolvers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiLayerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IApiHttpClientFactory, ApiHttpClientFactory>();

            services.AddScoped<ILogin, LoginController>();
            services.AddScoped<ISendDataController, SendDataController>();
            services.AddScoped<IGetMissingDatesController, GetMissingDatesController>();
            services.AddScoped<ISendCalibrationController, SendCalibrationController>();

            return services;
        }
    }
}
