using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    internal class ApiManager : IApiService
    {
        readonly IApiDal _apiDal;
        public ApiManager(IApiDal apiDal)
        {
            _apiDal = apiDal;
        }

        public IResult Add(Api api)
        {
            IResult result = BusinessRules.Run(CheckApiExist(api));

            if(result != null)
            {
                this.Update(api);
            }

            _apiDal.Add(api);

            return new SuccessResult(Messages.ApiAdded);
        }

        public IResult Update(Api api)
        {
            IResult result = BusinessRules.Run(CheckApiExist(api));

            if (!result.Success)
            {
                this.Add(api);
            }
            _apiDal.Update(api);

            return new SuccessResult(Messages.ApiUpdated);
        }
        
        public IDataResult<Api> Get()
        {
            return new SuccessDataResult<Api>(_apiDal.Get(a => a.Id == 1));
        }

        private IResult CheckApiExist(Api api)
        {
            var result = _apiDal.GetAll(a => a == api).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
