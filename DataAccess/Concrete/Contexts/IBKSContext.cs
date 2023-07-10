using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class IBKSContext : DbContext
    {
        public DbSet<Api> Apis { get; set; }
    }
}
