using Core.Utilities.Results;
using Entities.Concrete.API;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstract
{
    public interface ISendDataController
    {
        public Task<IDataResult<ResultStatus<SendDataResult>>> SendData([FromBody] SendData data);

    }
}
