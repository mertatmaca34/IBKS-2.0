using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBKSContext>();

            services.AddScoped<IApiService, ApiManager>();
            services.AddScoped<IApiDal, EfApiDal>();

            services.AddScoped<ICalibrationService, CalibrationManager>();
            services.AddScoped<ICalibrationDal, EfCalibrationDal>();

            services.AddScoped<ICalibrationLimitService, CalibrationLimitManager>();
            services.AddScoped<ICalibrationLimitDal, EfCalibrationLimitDal>();

            services.AddScoped<IDB41Service, DB41Manager>();
            services.AddScoped<IDB41Dal, EfDB41Dal>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<ISendDataService, SendDataManager>();
            services.AddScoped<ISendDataDal, EfSendDataDal>();

            services.AddScoped<IStationService, StationManager>();
            services.AddScoped<IStationDal, EfStationDal>();

            services.AddScoped<IMailStatementService, MailStatementManager>();
            services.AddScoped<IMailStatementDal, EfMailStatementDal>();

            services.AddScoped<IUserMailStatementService, UserMailStatementManager>();
            services.AddScoped<IUserMailStatementDal, EfUserMailStatementDal>();

            services.AddScoped<IMailServerService, MailServerManager>();
            services.AddScoped<IMailServerDal, EfMailServerDal>();

            services.AddScoped<IPlcService, PlcManager>();
            services.AddScoped<IPlcDal, EfPlcDal>();

            services.AddScoped<ISampleService, SampleManager>();
            services.AddScoped<ISampleDal, EfSampleDal>();

            services.AddScoped<IChannelService, ChannelManager>();
            services.AddScoped<IChannelDal, EfChannelDal>();

            services.AddScoped<IAuthService, AuthManager>();
            services.AddSingleton<ITokenHelper, JwtHelper>();

            return services;
        }
    }
}
