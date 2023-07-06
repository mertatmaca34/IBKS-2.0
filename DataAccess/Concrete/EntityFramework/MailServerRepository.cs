using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MailServerRepository : EfEntityRepositoryBase<MailServer, IBKSContext>, IMailServerDal { }
}
