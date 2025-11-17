using Microsoft.Extensions.DependencyInjection;
using Notifications.Mail.Abstract;
using Notifications.Mail.Services;
using Notifications.Services.Abstract;

namespace Notifications.DependencyResolvers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNotificationServices(this IServiceCollection services)
        {
            services.AddSingleton<ICheckStatements, CheckStatements>();
            services.AddSingleton<ISendMail, SendMail>();

            return services;
        }
    }
}
