using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using WebAPI.Abstract;
using WebAPI.Controllers;
using WebAPI.Utils;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoginController>().As<ILogin>().SingleInstance();
            builder.RegisterType<SendDataController>().As<ISendDataController>().SingleInstance();
            builder.RegisterType<GetMissingDatesController>().As<IGetMissingDatesController>().SingleInstance();
            builder.RegisterType<SendCalibrationController>().As<ISendCalibrationController>().SingleInstance();

            builder.RegisterType<SendCalibrationController>().As<ISendCalibrationController>().SingleInstance();

            builder.RegisterType<GetCalibrationController>().AsSelf();
            builder.RegisterType<DenemeController>().AsSelf();
            builder.RegisterType<GetChannelInformationController>().AsSelf();
            builder.RegisterType<GetDataController>().AsSelf();
            builder.RegisterType<GetLogController>().AsSelf();
            builder.RegisterType<GetPowerOffTimesController>().AsSelf();
            builder.RegisterType<GetPowerOffTimesController>().AsSelf();
            builder.RegisterType<GetServerDateTimeController>().AsSelf();
            builder.RegisterType<StartSampleController>().AsSelf();
            builder.RegisterType<GetLastDataDateController>().AsSelf();

            builder.RegisterType<HttpClientAssign>().As<IHttpClientAssign>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}