using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StationManager : IStationService
    {
        readonly IStationDal _stationDal;
        public StationManager(IStationDal stationDal)
        {
            _stationDal = stationDal;
        }
        public IResult Add(Station station)
        {
            IResult result = BusinessRules.Run(CheckStationExist(station));

            if (result != null)
            {
                this.Update(station);
            }

            _stationDal.Add(station);

            return new SuccessResult(Messages.StationAdded);
        }

        public IResult Update(Station station)
        {
            IResult result = BusinessRules.Run(CheckStationExist(station));

            if (!result.Success)
            {
                this.Add(station);
            }
            _stationDal.Update(station);

            return new SuccessResult(Messages.StationUpdated);
        }

        public IDataResult<Station> Get()
        {
            var result = _stationDal.Get(s => s.Id == 1);

            if (result != null)
                return new SuccessDataResult<Station>(result);

            return new ErrorDataResult<Station>(Messages.StationIsNotDefined);
        }

        private IResult CheckStationExist(Station station)
        {
            var result = _stationDal.GetAll(s => s == station).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
