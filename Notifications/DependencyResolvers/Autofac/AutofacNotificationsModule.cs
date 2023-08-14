using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Notifications.Mail.Abstract;
using Notifications.Mail.Services;
using Notifications.Services.Abstract;

namespace Notifications.DependencyResolvers.Autofac
{
    public class AutofacNotificationsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CheckStatements>().As<ICheckStatements>().SingleInstance();
            builder.RegisterType<SendMail>().As<ISendMail>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
