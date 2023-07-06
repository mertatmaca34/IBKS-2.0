using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class IBKSContext : DbContext
    {
        public DbSet<Api> Apis { get; set; }
    }
}
