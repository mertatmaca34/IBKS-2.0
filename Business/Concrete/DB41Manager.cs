using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DB41Manager : IDB41Service
    {
        IDB41Dal _dB41Dal;

        public DB41Manager(IDB41Dal dB41Dal)
        {
            _dB41Dal = dB41Dal;
        }

        public IResult Add(DB41 dB41)
        {
            IResult result = BusinessRules.Run(CheckDB41Exist(dB41));

            if (result != null)
            {
                _dB41Dal.Update(dB41);

                return new SuccessResult(Messages.DB41Updated);
            }

            _dB41Dal.Add(dB41);

            return new SuccessResult(Messages.DB41Added);
        }

        public IResult Delete(DB41 dB41)
        {
            IResult result = BusinessRules.Run(CheckDB41Exist(dB41));

            if (result != null)
            {
                _dB41Dal.Delete(dB41);

                return new SuccessResult(Messages.DB41Deleted);
            }

            return new ErrorDataResult<DB41>(Messages.InvalidDelete);
        }

        public IDataResult<List<DB41>> GetAll()
        {
            return new SuccessDataResult<List<DB41>>(_dB41Dal.GetAll());
        }

        public IResult Update(DB41 dB41)
        {
            IResult result = BusinessRules.Run(CheckDB41Exist(dB41));

            if (!result.Success)
            {
                _dB41Dal.Add(dB41);

                return new SuccessResult(Messages.DB41Added);
            }

            _dB41Dal.Update(dB41);

            return new SuccessResult(Messages.DB41Updated);
        }
        private IResult CheckDB41Exist(DB41 dB41)
        {
            var result = _dB41Dal.GetAll(d => d == dB41).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
