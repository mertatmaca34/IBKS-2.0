using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMailServerService
    {
        IDataResult<MailServer> Get();
        IResult Add(MailServer mailServer);
        IResult Update(MailServer mailServer);
    }
}
