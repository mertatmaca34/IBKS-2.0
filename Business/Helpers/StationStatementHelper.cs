using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Helpers
{
    public static class StationStatementHelper
    {
        public static IDataResult<SendData> GetLastWashTime(ISendDataService sendDataManager)
        {
            var res = sendDataManager.GetLastWashTime();

            if (res.Success)
            {
                return new SuccessDataResult<SendData>(res.Data.OrderByDescending(p=> p.Readtime).LastOrDefault());
            }
            else
            {
                return new ErrorDataResult<SendData>(Messages.WashDataNotFound);
            }
        }
    }
}