using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DataAccess.Concrete.Contexts
{
    public class IBKSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("SqlServer");

                if (!string.IsNullOrEmpty(connectionString))
                {
                    try
                    {
                        optionsBuilder.UseSqlServer(connectionString);

                        using var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                        connection.Open();
                    }
                    catch
                    {
                        // hata olursa sessizce geç
                    }
                }
            }
        }

        public DbSet<Api> Apis { get; set; }
        public DbSet<Calibration> Calibrations { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<DB12> DB12s { get; set; }
        public DbSet<DB4> DB4s { get; set; }
        public DbSet<DB41> DB41s { get; set; }
        public DbSet<InputTags> InputTags { get; set; }
        public DbSet<MailServer> MailServers { get; set; }
        public DbSet<MailStatement> MailStatements { get; set; }
        public DbSet<MBTags> MBTags { get; set; }
        public DbSet<Plc> Plcs { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<SendData> SendDatas { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CalibrationLimit> CalibrationLimits { get; set; }
        public DbSet<UserMailStatement> UserMailStatements { get; set; }
    }
}

