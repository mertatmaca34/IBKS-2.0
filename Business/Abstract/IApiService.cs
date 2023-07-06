using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApiService
    {
        IDataResult<List<Api>> GetAll();
        IDataResult<Api> GetById(int apiId);
        IResult Add(Api api);
        IResult Update(Api api);
        //IResult AddTransactionalTest(Api product);
    }
}
