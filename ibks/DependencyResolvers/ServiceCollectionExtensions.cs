using ibks.Forms;
using ibks.Services.Mail.Abstract;
using ibks.Services.Mail.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ibks.DependencyResolvers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWinFormsDependencies(this IServiceCollection services)
        {
            services.AddScoped<Main>();
            services.AddScoped<ICheckStatements, CheckStatements>();
            services.AddScoped<ISendMail, SendMail>();

            return services;
        }
    }
}
