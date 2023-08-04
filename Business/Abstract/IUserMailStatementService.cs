using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserMailStatementService
    {
        IDataResult<List<UserMailStatement>> GetAll();
        IResult Add(UserMailStatement userMailStatement);
        IResult Delete(UserMailStatement userMailStatement);
        IResult Update(UserMailStatement userMailStatement);
    }
}
