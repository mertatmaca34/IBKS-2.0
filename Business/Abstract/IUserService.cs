using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        List<User> GetAll();
        void Add(User user);
        void Delete(User user);
        User GetByMail(string email);
    }
}
