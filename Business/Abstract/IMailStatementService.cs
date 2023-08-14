using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMailStatementService
    {
        IDataResult<List<MailStatement>> GetAll();
        IDataResult<MailStatement> Get(Expression<Func<MailStatement, bool>> filter);
        IResult Add(MailStatement mailStatement);
        IResult Delete(MailStatement mailStatement);
        IResult Update(MailStatement mailStatement);
    }
}
