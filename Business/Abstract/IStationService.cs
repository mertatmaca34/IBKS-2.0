using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStationService
    {
        IDataResult<Station> Get();
        IResult Add(Station station);
        IResult Update(Station station);
    }
}
