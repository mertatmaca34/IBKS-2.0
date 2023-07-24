using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICalibrationLimitService
    {
        IDataResult<CalibrationLimit> Get(Expression<Func<CalibrationLimit, bool>> filter);
        IResult Add(CalibrationLimit calibrationLimit);
        IResult Update(CalibrationLimit calibrationLimit);
    }
}
