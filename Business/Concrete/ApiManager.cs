using Business.Abstract;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class ApiManager : IApiService
    {
        IApiDal _apiDal;
        public ApiManager(IApiDal apiDal)
        {
            _apiDal = apiDal;
        }

        public IResult Add(Api api)
        {
            IResult result = BusinessRules.Run()
        }

        public IDataResult<List<Api>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Api> GetById(int apiId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Api api)
        {
            throw new NotImplementedException();
        }

        private IResult CheckApiExist(Api api)
        {
            var result = _apiDal.GetAll(a => a.ApiAdress == api.ApiAdress).Any();
            if(result)
            {
                return ErrorResult
            }
        }
    }
}
