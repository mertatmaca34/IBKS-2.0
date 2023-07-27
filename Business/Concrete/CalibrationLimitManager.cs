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

            if (result == null)
            {
                this.Update(calibrationLimit);

                return new SuccessResult(Messages.CalibrationLimitUpdated);
            }
            else if (result != null)
            {
                _calibrationLimitDal.Add(calibrationLimit);

                return new SuccessResult(Messages.CalibrationLimitAdded);
            }

            return new ErrorResult(Messages.CalibrationLimitIncompleteInfo);
        }

        public IResult Update(CalibrationLimit calibrationLimit)
        {
            IResult result = BusinessRules.Run(CheckCalibrationLimitExist(calibrationLimit));

            if (result == null)
            {
                var existEntity = _calibrationLimitDal.GetAll().Where(c => c.Parameter == calibrationLimit.Parameter).FirstOrDefault();

                if (existEntity != null)
                {
                    calibrationLimit.Id = existEntity.Id;

                    _calibrationLimitDal.Update(calibrationLimit);

                    return new SuccessResult(Messages.CalibrationLimitUpdated);
                }
            }

            this.Add(calibrationLimit);

            return new SuccessResult(Messages.CalibrationLimitUpdated);
        }

        public IDataResult<CalibrationLimit> Get(Expression<Func<CalibrationLimit, bool>> filter)
        {
            return new SuccessDataResult<CalibrationLimit>(_calibrationLimitDal.Get(filter));
        }

        private IResult CheckCalibrationLimitExist(CalibrationLimit calibrationLimit)
        {
            if (calibrationLimit != null)
            {
                var data = _calibrationLimitDal.GetAll();

                var filteredData = data.Where(d => d.Parameter == calibrationLimit.Parameter).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.CalibrationLimitIncompleteInfo);
        }
    }
}