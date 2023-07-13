using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDB41Dal : EfEntityRepositoryBase<DB41, IBKSContext>, IDB41Dal { }
}
