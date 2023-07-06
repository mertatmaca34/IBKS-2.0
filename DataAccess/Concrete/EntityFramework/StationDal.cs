using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class StationDal : EfEntityRepositoryBase<Station, IBKSContext>, IStationDal { }
}
