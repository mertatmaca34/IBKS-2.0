using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SendDataManager : ISendDataService
    {
        ISendDataDal _sendDataDal;

        public SendDataManager(ISendDataDal sendDataDal)
        {
            _sendDataDal = sendDataDal;
        }

        public IResult Add(SendData sendData)
        {
            IResult result = BusinessRules.Run(CheckSendDataExist(sendData));

            if (result == null)
            {
                this.Update(sendData);

                return new SuccessResult(Messages.SendDataUpdated);
            }
            else if (result != null)
            {
                _sendDataDal.Add(sendData);

                return new SuccessResult(Messages.SendDataAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IResult Delete(SendData sendData)
        {
            IResult result = BusinessRules.Run(CheckSendDataExist(sendData));

            if (result != null)
            {
                _sendDataDal.Delete(sendData);

                return new SuccessResult(Messages.SendDataDeleted);
            }

            return new ErrorDataResult<SendData>(Messages.InvalidDelete);
        }

        public IDataResult<List<SendData>> GetAll(Expression<Func<SendData, bool>> filter = null)
        {
            return new SuccessDataResult<List<SendData>>(_sendDataDal.GetAll(filter));
        }

        public IDataResult<List<SendData>> GetLast60Minutes()
        {
            var data = _sendDataDal.GetAll(d => d.Readtime >= DateTime.Now.AddMinutes(-60));

            return new SuccessDataResult<List<SendData>>(data);
        }

        public IDataResult<List<SendData>> GetLastWashTime()
        {
            return new SuccessDataResult<List<SendData>>(_sendDataDal.GetAll(d => d.AKM_Status == 23));
        }

        public IDataResult<List<SendData>> GetLastWashWeekTime()
        {
            return new SuccessDataResult<List<SendData>>(_sendDataDal.GetAll(d => d.AKM_Status == 24));
        }

        public IResult Update(SendData sendData)
        {
            IResult result = BusinessRules.Run(CheckSendDataExist(sendData));

            if (result == null)
            {
                _sendDataDal.Update(sendData);

                return new SuccessResult(Messages.SendDataUpdated);
            }

            this.Add(sendData);

            return new SuccessResult(Messages.SendDataAdded);
        }

        private IResult CheckSendDataExist(SendData sendData)
        {
            if (sendData != null)
            {
                var filteredData = _sendDataDal.GetAll(d => d.Id == sendData.Id).FirstOrDefault();

                if (filteredData != null)
                {
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult(Messages.DataNotFound);
                }
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }
    }
}
