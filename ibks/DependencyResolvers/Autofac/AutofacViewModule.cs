using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using ibks.Forms;
using ibks.Forms.Pages;
using ibks.Services.Mail.Abstract;
using ibks.Services.Mail.Services;

namespace ibks.DependencyResolvers.Autofac
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
