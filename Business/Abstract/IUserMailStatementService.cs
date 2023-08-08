using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserMailStatementService
    {
        IDataResult<List<UserMailStatement>> GetAll();
        IDataResult<List<UserMailStatement>> Get(Expression<Func<UserMailStatement, bool>> filter);
        IResult Add(UserMailStatement userMailStatement);
        IResult Delete(UserMailStatement userMailStatement);
        IResult Update(UserMailStatement userMailStatement);
    }
}
