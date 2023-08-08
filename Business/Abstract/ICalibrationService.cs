using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICalibrationService
    {
        IDataResult<List<Calibration>> GetAll(Expression<Func<Calibration, bool>> filter = null);
        IResult Add(Calibration calibration);
        IDataResult<List<Calibration>> GetByDateTime(DateTime startTime, DateTime endTime);
        IDataResult<List<Calibration>> GetPhCalibrations();
        IDataResult<List<Calibration>> GetIletkenlikCalibrations();
        IDataResult<List<Calibration>> GetAkmCalibrations();
        IDataResult<List<Calibration>> GetKoiCalibrations();
    }
}
