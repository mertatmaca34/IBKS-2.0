using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    internal class UserMailStatementManager : IUserMailStatementService
    {
        IUserMailStatementDal _userMailStatementDal;

        public UserMailStatementManager(IUserMailStatementDal userMailStatementDal)
        {
            _userMailStatementDal = userMailStatementDal;
        }

        public IResult Add(UserMailStatement userMailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(userMailStatement));

            if (result == null)
            {
                this.Update(userMailStatement);

                return new SuccessResult(Messages.UserMailStatementUpdated);
            }
            else if (result != null)
            {
                _userMailStatementDal.Add(userMailStatement);

                return new SuccessResult(Messages.UserMailStatementAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(UserMailStatement userMailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(userMailStatement));

            if (result == null)
            {
                _userMailStatementDal.Delete(userMailStatement);

                return new SuccessResult(Messages.UserMailStatementDeleted);
            }

            if (userMailStatement.MailStatementId > 0 && userMailStatement.UserId == 0)
            {
                var data = _userMailStatementDal.GetAll(x => x.MailStatementId == userMailStatement.MailStatementId);

                foreach (var item in data)
                {
                    _userMailStatementDal.Delete(item);
                }

                return new SuccessResult(Messages.UserMailStatementDeleted);
            }

            return new ErrorDataResult<UserMailStatement>(Messages.InvalidDelete);
        }

        public IDataResult<List<UserMailStatement>> Get(Expression<Func<UserMailStatement, bool>> filter)
        {
            return new SuccessDataResult<List<UserMailStatement>>(_userMailStatementDal.GetAll(filter));
        }

        public IDataResult<List<UserMailStatement>> GetAll()
        {
            return new SuccessDataResult<List<UserMailStatement>>(_userMailStatementDal.GetAll());
        }

        public IResult Update(UserMailStatement userMailStatement)
        {
            IResult result = BusinessRules.Run(CheckMailStatementExist(userMailStatement));

            if (result == null)
            {
                var existEntity = _userMailStatementDal.GetAll().Where(c => c.UserId == userMailStatement.UserId
                && c.MailStatementId == userMailStatement.MailStatementId).FirstOrDefault();

                if (existEntity != null)
                {
                    userMailStatement.Id = existEntity.Id;

                    _userMailStatementDal.Update(userMailStatement);

                    return new SuccessResult(Messages.UserMailStatementUpdated);
                }
            }

            this.Add(userMailStatement);

            return new SuccessResult(Messages.UserMailStatementAdded);
        }
        private IResult CheckMailStatementExist(UserMailStatement userMailStatement)
        {
            if (userMailStatement != null)
            {
                var data = _userMailStatementDal.GetAll();

                var filteredData = _userMailStatementDal.GetAll().Where(c => c.UserId == userMailStatement.UserId
                && c.MailStatementId == userMailStatement.MailStatementId).FirstOrDefault();

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
