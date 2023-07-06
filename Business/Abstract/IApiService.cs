using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApiService
    {
        IDataResult<List<Api>> GetAll();
        IDataResult<List<Api>> GetAllByCategoryId(int id);
        IDataResult<List<Api>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<Api>> GetProductDetails();
        IDataResult<Api> GetById(int productId);
        IResult Add(Api product);
        IResult Update(Api product);
        IResult AddTransactionalTest(Api product);
    }
}
