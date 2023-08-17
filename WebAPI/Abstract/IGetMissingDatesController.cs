using Core.Utilities.Results;
using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstract
{
    public interface IGetMissingDatesController
    {
        public Task<IDataResult<ResultStatus>> GetMissingDates([FromBody] Guid stationId);
    }
}
