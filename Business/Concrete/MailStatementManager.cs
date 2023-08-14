using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MailStatementManager : IMailStatementService
    {
        readonly IMailStatementDal _mailStatementDal;

        public MailStatementManager(IMailStatementDal mailStatementDal)
        {
            _mailStatementDal = mailStatementDal;
        }

        public IResult Add(MailStatement mailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(mailStatement));

            if (result == null)
            {
                this.Update(mailStatement);

                return new SuccessResult(Messages.MailStatementUpdated);
            }
            else if (result != null)
            {
                _mailStatementDal.Add(mailStatement);

                return new SuccessResult(Messages.MailStatementAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(MailStatement mailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(mailStatement));

            if (result == null)
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

            if (result == null)
            {
                var existEntity = _mailStatementDal.GetAll().Where(c => c.StatementName == mailStatement.StatementName).FirstOrDefault();

                if (existEntity != null)
                {
                    mailStatement.Id = existEntity.Id;

                    _mailStatementDal.Update(mailStatement);

                    return new SuccessResult(Messages.MailStatementUpdated);
                }
            }

            this.Add(mailStatement);

            return new SuccessResult(Messages.MailStatementAdded);
        }
        private IResult CheckMailStatementExist(MailStatement mailStatement)
        {
            if (mailStatement != null)
            {
                var data = _mailStatementDal.GetAll();

                var filteredData = data.Where(d => d.StatementName == mailStatement.StatementName).FirstOrDefault();

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

        IDataResult<MailStatement> IMailStatementService.Get(Expression<Func<MailStatement, bool>> filter)
        {
            return new SuccessDataResult<MailStatement>(_mailStatementDal.Get(filter));
        }
    }
}
