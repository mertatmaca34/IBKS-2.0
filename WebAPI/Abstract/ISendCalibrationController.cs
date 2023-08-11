using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstract
{
    public interface ISendCalibrationController
    {
        public Task<IDataResult<ResultStatus>> SendCalibration([FromBody] SendCalibration data);
    }
}
