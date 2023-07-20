using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

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

            if (result != null)
            {
                _sendDataDal.Update(sendData);

                return new SuccessResult(Messages.SendDataUpdated);
            }

            _sendDataDal.Add(sendData);

            return new SuccessResult(Messages.SendDataAdded);
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

        public IDataResult<List<SendData>> GetAll()
        {
            return new SuccessDataResult<List<SendData>>(_sendDataDal.GetAll());
        }

        public IDataResult<List<SendData>> GetLast60Minutes()
        {
            return new SuccessDataResult<List<SendData>>(_sendDataDal.GetAll(d=> d.Readtime >= DateTime.Now.AddMinutes(-60)));
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

            if (!result.Success)
            {
                _sendDataDal.Add(sendData);

                return new SuccessResult(Messages.SendDataAdded);
            }

            _sendDataDal.Update(sendData);

            return new SuccessResult(Messages.SendDataUpdated);
        }

        private IResult CheckSendDataExist(SendData sendData)
        {
            var result = _sendDataDal.GetAll(m => m == sendData).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
