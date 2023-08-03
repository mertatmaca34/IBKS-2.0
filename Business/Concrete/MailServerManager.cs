using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MailServerManager : IMailServerService
    {
        readonly IMailServerDal _mailServerDal;

        public MailServerManager(IMailServerDal mailServerDal)
        {
            _mailServerDal = mailServerDal;
        }

        public IResult Add(MailServer mailServer)
        {
            IResult result = BusinessRules.Run(CheckMailServerExist(mailServer));

            if (result == null)
            {
                this.Update(mailServer);

                return new SuccessResult(Messages.MailServerUpdated);
            }
            else if (result != null)
            {
                _mailServerDal.Add(mailServer);

                return new SuccessResult(Messages.MailServerAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IDataResult<MailServer> Get()
        {
            var data = _mailServerDal.Get(s => s.Id == 1);

            if (data != null)
            {
                return new SuccessDataResult<MailServer>(data);
            }

            return new ErrorDataResult<MailServer>();
        }

        public IResult Update(MailServer mailServer)
        {
            IResult result = BusinessRules.Run(CheckMailServerExist(mailServer));

            if (result == null)
            {
                var existEntity = _mailServerDal.GetAll().Where(c => c.Id == 1).FirstOrDefault();

                if (existEntity != null)
                {
                    mailServer.Id = existEntity.Id;

                    _mailServerDal.Update(mailServer);

                    return new SuccessResult(Messages.MailServerUpdated);
                }
            }

            this.Add(mailServer);

            return new SuccessResult(Messages.MailServerUpdated);
        }

        private IResult CheckMailServerExist(MailServer mailServer)
        {
            if (mailServer != null)
            {
                var data = _mailServerDal.GetAll();

                var filteredData = data.Where(d => d.Id == 1).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }
    }
}
