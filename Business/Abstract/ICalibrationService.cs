using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICalibrationService
    {
        IDataResult<List<Calibration>> GetAll();
        IResult Add(Calibration calibration);
        IDataResult<Calibration> GetByDateTime(DateTime startTime, DateTime endTime);
    }
}
