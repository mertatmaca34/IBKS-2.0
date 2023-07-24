using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MailStatementManager : IMailStatementService
    {
        IMailStatementDal _mailStatementDal;

        public MailStatementManager(IMailStatementDal mailStatementDal)
        {
            _mailStatementDal = mailStatementDal;
        }

        public IResult Add(MailStatement mailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(mailStatement));

            if (result != null)
            {
                _mailStatementDal.Update(mailStatement);

                return new SuccessResult(Messages.MailStatementUpdated);
            }

            _mailStatementDal.Add(mailStatement);

            return new SuccessResult(Messages.MailStatementAdded);
        }

        public IResult Delete(MailStatement mailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(mailStatement));

            if (result != null)
            {
                _mailStatementDal.Delete(mailStatement);

                return new SuccessResult(Messages.MailStatementDeleted);
            }

            return new ErrorDataResult<MailStatement>(Messages.InvalidDelete);
        }

        public IDataResult<List<MailStatement>> GetAll()
        {
            return new SuccessDataResult<List<MailStatement>>(_mailStatementDal.GetAll());
        }

        public IResult Update(MailStatement mailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(mailStatement));

            if (!result.Success)
            {
                _mailStatementDal.Add(mailStatement);

                return new SuccessResult(Messages.MailStatementAdded);
            }

            _mailStatementDal.Update(mailStatement);

            return new SuccessResult(Messages.MailStatementUpdated);
        }
        private IResult CheckMailStatementExist(MailStatement mailStatement)
        {
            var result = _mailStatementDal.GetAll(m => m == mailStatement).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
