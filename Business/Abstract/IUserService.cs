using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        List<User> GetAll();
        void Add(User user);
        void Delete(User user);
        User GetByMail(string email);
        IDataResult<User> Get(Expression<Func<User, bool>> filter);
    }
}
