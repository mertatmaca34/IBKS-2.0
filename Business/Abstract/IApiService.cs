using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApiService
    {
        IDataResult<Api> Get();
        IResult Add(Api api);
        IResult Update(Api api);
    }
}
