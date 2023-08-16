using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using IBKS_2._0.Forms;
using IBKS_2._0.Forms.Pages;
using IBKS_2._0.Services.Mail.Abstract;
using IBKS_2._0.Services.Mail.Services;

namespace IBKS_2._0.DependencyResolvers.Autofac
{
    public class AutofacViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Main>().AsSelf();
            builder.RegisterType<HomePage>().As<Form>().SingleInstance();
            builder.RegisterType<CalibrationPage>().As<Form>().SingleInstance();

            builder.RegisterType<MailPage>().As<Form>().SingleInstance();
            builder.RegisterType<ReportingPage>().As<Form>().SingleInstance();

            builder.RegisterType<SettingsPage>().As<Form>().SingleInstance();
            builder.RegisterType<SimulationPage>().As<Form>().SingleInstance();

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
