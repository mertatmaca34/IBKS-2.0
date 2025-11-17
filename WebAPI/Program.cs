using Business.DependencyResolvers;
using Microsoft.AspNetCore.Authentication;
using WebAPI.Authrozation;
using WebAPI.DependencyResolvers;
using WebAPI.Middlewares;

namespace WebAPI
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            builder.Services.AddAuthorization();

            builder.Services.AddBusinessDependencies();
            builder.Services.AddApiLayerDependencies();

            builder.Services.AddMemoryCache();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddHttpClient("ExternalApi", client =>
            {
                client.Timeout = TimeSpan.FromSeconds(30);
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseMiddleware<BasicAuthMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}