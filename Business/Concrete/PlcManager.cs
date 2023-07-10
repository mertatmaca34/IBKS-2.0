using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlcManager : IPlcService
    {
        IPlcDal _plcDal;
        public PlcManager(IPlcDal plcDal)
        {
            _plcDal = plcDal;
        }

        public IResult Add(Plc plc)
        {
            IResult result = BusinessRules.Run(CheckPlcExist(plc));

            if (result != null)
            {
                _plcDal.Update(plc);

                return new SuccessResult(Messages.PlcUpdated);
            }

            _plcDal.Add(plc);

            return new SuccessResult(Messages.PlcAdded);
        }

        public IDataResult<Plc> Get()
        {
            return new SuccessDataResult<Plc>(_plcDal.Get(p => p.Id == 1));
        }

        public IResult Update(Plc plc)
        {
            IResult result = BusinessRules.Run(CheckPlcExist(plc));

            if (!result.Success)
            {
                _plcDal.Add(plc);

                return new SuccessResult(Messages.PlcAdded);
            }
            _plcDal.Update(plc);

            return new SuccessResult(Messages.PlcUpdated);
        }
        private IResult CheckPlcExist(Plc plc)
        {
            var result = _plcDal.GetAll(p => p == plc).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
