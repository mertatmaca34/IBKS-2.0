using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class IBKSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=IKBS;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public IBKSContext(DbContextOptions<IBKSContext> options) : base(options)
        {
            Database.EnsureCreated();
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
        public DbSet<SendData> SendDatas{ get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
