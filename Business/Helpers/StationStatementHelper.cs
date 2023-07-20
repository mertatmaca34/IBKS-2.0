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
                return new SuccessDataResult<SendData>(res.Data.OrderByDescending(p=> p.Readtime).FirstOrDefault());
            }
            else
            {
                return new ErrorDataResult<SendData>(Messages.WashDataNotFound);
            }
        }

        public static IDataResult<SendData> GetLastWashWeekTime(ISendDataService sendDataManager)
        {
            var res = sendDataManager.GetLastWashWeekTime();

            if (res.Success)
            {
                return new SuccessDataResult<SendData>(res.Data.OrderByDescending(p=> p.Readtime).FirstOrDefault());
            }
            else
            {
                return new ErrorDataResult<SendData>(Messages.WashDataNotFound);
            }
        }

        public static IDataResult<Calibration> GetLastPhCalibration(ICalibrationService calibrationManager)
        {
            var res = calibrationManager.GetPhCalibrations();

            if (res.Success && res.Data.Count > 0)
            {
                return new SuccessDataResult<Calibration>(res.Data.OrderByDescending(c => c.TimeStamp).LastOrDefault());
            }
            else
            {
                return new ErrorDataResult<Calibration>(Messages.DataNotFound);
            }
        }

        public static IDataResult<Calibration> GetLastIletkenlikCalibration(ICalibrationService calibrationManager)
        {
            var res = calibrationManager.GetIletkenlikCalibrations();

            if (res.Success && res.Data.Count > 0)
            {
                return new SuccessDataResult<Calibration>(res.Data.OrderByDescending(c => c.TimeStamp).LastOrDefault());
            }
            else
            {
                return new ErrorDataResult<Calibration>(Messages.DataNotFound);
            }
        }
    }
}