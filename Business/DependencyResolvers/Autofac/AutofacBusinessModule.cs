using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IBKSContext>().AsSelf();

            builder.RegisterType<ApiManager>().As<IApiService>().SingleInstance();
            builder.RegisterType<EfApiDal>().As<IApiDal>().SingleInstance();

            builder.RegisterType<CalibrationManager>().As<ICalibrationService>().SingleInstance();
            builder.RegisterType<EfCalibrationDal>().As<ICalibrationDal>().SingleInstance();

            builder.RegisterType<DB41Manager>().As<IDB41Service>().SingleInstance();
            builder.RegisterType<EfDB41Dal>().As<IDB41Dal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<SendDataManager>().As<ISendDataService>();
            builder.RegisterType<EfSendDataDal>().As<ISendDataDal>();

            builder.RegisterType<StationManager>().As<IStationService>();
            builder.RegisterType<EfStationDal>().As<IStationDal>();

            builder.RegisterType<MailStatementManager>().As<IMailStatementService>();
            builder.RegisterType<EfMailStatementDal>().As<IMailStatementDal>();

            builder.RegisterType<UserMailStatementManager>().As<IUserMailStatementService>();
            builder.RegisterType<EfUserMailStatementDal>().As<IUserMailStatementDal>();

            builder.RegisterType<CalibrationLimitManager>().As<ICalibrationLimitService>();
            builder.RegisterType<EfCalibrationLimitDal>().As<ICalibrationLimitDal>();

            builder.RegisterType<MailServerManager>().As<IMailServerService>();
            builder.RegisterType<EfMailServerDal>().As<IMailServerDal>();

            builder.RegisterType<PlcManager>().As<IPlcService>();
            builder.RegisterType<EfPlcDal>().As<IPlcDal>();

            builder.RegisterType<SampleManager>().As<ISampleService>().SingleInstance();
            builder.RegisterType<EfSampleDal>().As<ISampleDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}