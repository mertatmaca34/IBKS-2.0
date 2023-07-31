using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PlcManager : IPlcService
    {
        readonly IPlcDal _plcDal;

        public PlcManager(IPlcDal plcDal)
        {
            _plcDal = plcDal;
        }

        public IResult Add(Plc plc)
        {
            IResult result = BusinessRules.Run(CheckPlcExist(plc));

            if (result == null)
            {
                this.Update(plc);

                return new SuccessResult(Messages.PlcUpdated);
            }
            else if (result != null)
            {
                _plcDal.Add(plc);

                return new SuccessResult(Messages.PlcAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IDataResult<Plc> Get()
        {
            var data = _plcDal.Get(p => p.Id == 1);

            if (data != null)
            {
                return new SuccessDataResult<Plc>(data);
            }

            return new ErrorDataResult<Plc>();
        }


        public IResult Update(Plc plc)
        {
            IResult result = BusinessRules.Run(CheckPlcExist(plc));

            if (result == null)
            {
                var existEntity = _plcDal.GetAll().Where(c => c.Id == 1).FirstOrDefault();

                if (existEntity != null)
                {
                    plc.Id = existEntity.Id;

                    _plcDal.Update(plc);

                    return new SuccessResult(Messages.PlcUpdated);
                }
            }

            this.Add(plc);

            return new SuccessResult(Messages.PlcUpdated);
        }

        private IResult CheckPlcExist(Plc plc)
        {
            if (plc != null)
            {
                var data = _plcDal.GetAll();

                var filteredData = data.Where(d => d.Id == 1).FirstOrDefault();

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
