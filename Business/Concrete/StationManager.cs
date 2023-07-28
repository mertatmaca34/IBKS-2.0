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

            if (result == null)
            {
                this.Update(station);

                return new SuccessResult(Messages.StationUpdated);
            }
            else if (result != null)
            {
                _stationDal.Add(station);

                return new SuccessResult(Messages.StationAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IDataResult<Station> Get()
        {
            return new SuccessDataResult<Station>(_stationDal.Get(s => s.Id == 1));
        }


        public IResult Update(Station station)
        {
            IResult result = BusinessRules.Run(CheckStationExist(station));

            if (result == null)
            {
                var existEntity = _stationDal.GetAll().Where(c => c.Id == 1).FirstOrDefault();

                if (existEntity != null)
                {
                    station.Id = existEntity.Id;

                    _stationDal.Update(station);

                    return new SuccessResult(Messages.StationUpdated);
                }
            }

            this.Add(station);

            return new SuccessResult(Messages.StationUpdated);
        }

        private IResult CheckStationExist(Station station)
        {
            if (station != null)
            {
                var data = _stationDal.GetAll();

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
