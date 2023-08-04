using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMailStatementService
    {
        IDataResult<List<MailStatement>> GetAll();
        IResult Add(MailStatement mailStatement);
        IResult Delete(MailStatement mailStatement);
        IResult Update(MailStatement mailStatement);
    }
}
