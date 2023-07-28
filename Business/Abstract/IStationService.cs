using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IStationService
    {
        IDataResult<Station> Get();
        IResult Add(Station station);
        IResult Update(Station station);
    }
}
