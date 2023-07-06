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

        public IDataResult<List<Calibration>> GetAll()
        {
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll());
        }

        [ValidationAspect(typeof(CalibrationValidator))]
        public IDataResult<List<Calibration>> GetByDateTime(DateTime startTime, DateTime endTime)
        {
            IResult result = BusinessRules.Run();

            if (result != null)
            {
                return new SuccessResult(Messages.CalibrationNotAdded);
            }
            return new SuccessDataResult<List<Calibration>>(_calibrationDal.GetAll(c => c.TimeStamp > startTime && c.TimeStamp < endTime));
        }
    }
}