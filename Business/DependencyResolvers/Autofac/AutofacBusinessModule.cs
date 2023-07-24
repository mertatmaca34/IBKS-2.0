using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
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

            /*builder.RegisterType<CalibrationLimitManager>().As<ICalibrationLimitService>();
            builder.RegisterType<EfCalibrationDal>().As<ICalibrationLimitDal>();*/

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