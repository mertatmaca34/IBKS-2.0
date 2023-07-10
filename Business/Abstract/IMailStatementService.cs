using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
