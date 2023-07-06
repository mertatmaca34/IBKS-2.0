using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class IBKSContext : DbContext
    {
        public DbSet<Api> Apis { get; set; }
    }
}
