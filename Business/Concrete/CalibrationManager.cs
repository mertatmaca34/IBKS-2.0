using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CalibrationManager : ICalibrationService
    {
        ICalibrationDal _calibrationDal;
        public CalibrationManager(ICalibrationDal calibrationDal)
        {
            _calibrationDal = calibrationDal;
        }
        public IResult Add(Calibration calibration)
        {
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return new SuccessResult(Messages.CalibrationNotAdded);
            }

            _calibrationDal.Add(calibration);

            return new SuccessResult(Messages.CalibrationAdded);
        }


        public IDataResult<List<Calibration>> GetAll(Expression<Func<Calibration, bool>> filter = null)
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(filter));
        }

        [ValidationAspect(typeof(CalibrationValidator))]
        public IDataResult<List<Calibration>> GetByDateTime(DateTime startTime, DateTime endTime)
        {
            IResult result = BusinessRules.Run(CheckIfDateTimeInCorrect(startTime, endTime));

            if (result != null)
            {
                return new ErrorDataResult<List<Calibration>>(Messages.CalibrationNotFound);
            }

            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.TimeStamp > startTime && c.TimeStamp < endTime));
        }

        public IDataResult<List<Calibration>> GetIletkenlikCalibrations()
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.Parameter == "Iletkenlik"));
        }

        public IDataResult<List<Calibration>> GetAkmCalibrations()
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.Parameter == "Akm"));
        }

        public IDataResult<List<Calibration>> GetKoiCalibrations()
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.Parameter == "Koi"));
        }

        public IDataResult<List<Calibration>> GetPhCalibrations()
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.Parameter == "Ph"));
        }

        private IResult CheckIfDateTimeInCorrect(DateTime startTime, DateTime endTime)
        {
            if (startTime > endTime && startTime > DateTime.Now)
            {
                return new ErrorResult(Messages.InvalidDateTimes);
            }

            return new SuccessResult();
        }
    }
}