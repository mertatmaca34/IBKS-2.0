using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MailServerManager : IMailServerService
    {
        IMailServerDal _mailServerDal;
        public MailServerManager(IMailServerDal mailServerDal)
        {
           _mailServerDal = mailServerDal;
        }
        public IResult Add(MailServer mailServer)
        {
            IResult result = BusinessRules.Run(CheckMailServerExist(mailServer));

            if (result != null)
            {
                _mailServerDal.Update(mailServer);
                return new SuccessResult(Messages.MailServerUpdated);
            }

            _mailServerDal.Add(mailServer);

            return new SuccessResult(Messages.MailServerAdded);
        }

        public IDataResult<MailServer> Get()
        {
            return new SuccessDataResult<MailServer>(_mailServerDal.Get(m => m.Id == 1));
        }

        public IResult Update(MailServer mailServer)
        {
            IResult result = BusinessRules.Run(CheckMailServerExist(mailServer));

            if (!result.Success)
            {
                _mailServerDal.Add(mailServer);
                return new SuccessResult(Messages.MailServerAdded);
            }

            _mailServerDal.Update(mailServer);

            return new SuccessResult(Messages.MailServerUpdated);
        }

        private IResult CheckMailServerExist(MailServer mailServer)
        {
            var result = _mailServerDal.GetAll(m => m == mailServer).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
