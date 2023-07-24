using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CalibrationLimitManager : ICalibrationLimitService
    {
        readonly ICalibrationLimitDal _calibrationLimitDal;

        public CalibrationLimitManager(ICalibrationLimitDal calibrationLimitDal)
        {
            _calibrationLimitDal = calibrationLimitDal;
        }

        public IResult Add(CalibrationLimit calibrationLimit)
        {
            IResult result = BusinessRules.Run(CheckCalibrationLimitExist(calibrationLimit));

            if (result != null)
            {
                this.Update(calibrationLimit);
            }

            _calibrationLimitDal.Add(calibrationLimit);

            return new SuccessResult(Messages.CalibrationLimitAdded);
        }

        public IResult Update(CalibrationLimit calibrationLimit)
        {
            IResult result = BusinessRules.Run(CheckCalibrationLimitExist(calibrationLimit));

            if (!result.Success)
            {
                this.Add(calibrationLimit);
            }
            _calibrationLimitDal.Update(calibrationLimit);

            return new SuccessResult(Messages.CalibrationLimitUpdated);
        }

        public IDataResult<CalibrationLimit> Get(Expression<Func<CalibrationLimit, bool>> filter)
        {
            return new SuccessDataResult<CalibrationLimit>(_calibrationLimitDal.Get(filter));
        }

        private IResult CheckCalibrationLimitExist(CalibrationLimit calibrationLimit)
        {
            var result = _calibrationLimitDal.GetAll(a => a == calibrationLimit).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}