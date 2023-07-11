using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using IBKS_2._0.Forms.Pages;

namespace IBKS_2._0.DependencyResolvers.Autofac
{
    public class AutofacViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HomePage>().As<Form>().SingleInstance();
            builder.RegisterType<CalibrationPage>().As<Form>().SingleInstance();

            builder.RegisterType<MailPage>().As<Form>().SingleInstance();
            builder.RegisterType<ReportingPage>().As<Form>().SingleInstance();

            builder.RegisterType<SettingsPage>().As<Form>().SingleInstance();
            builder.RegisterType<SimulationPage>().As<Form>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
