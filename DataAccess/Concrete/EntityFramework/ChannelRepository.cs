using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class ChannelRepository : EfEntityRepositoryBase<Channel, IBKSContext>, IChannelDal { }
}
