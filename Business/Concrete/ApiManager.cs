using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ApiManager : IApiService
    {
        readonly IApiDal _apiDal;

        public ApiManager(IApiDal apiDal)
        {
            _apiDal = apiDal;
        }

        public IResult Add(Api api)
        {
            IResult result = BusinessRules.Run(CheckApiExist(api));

            if (result == null)
            {
                this.Update(api);

                return new SuccessResult(Messages.ApiUpdated);
            }
            else if (result != null)
            {
                _apiDal.Add(api);

                return new SuccessResult(Messages.ApiAdded);
            }

            return new ErrorResult(Messages.IncompleteInfo);
        }

        public IDataResult<Api> Get()
        {
            var data = _apiDal.Get(s => s.Id == 1);

            if(data != null)
            {
                return new SuccessDataResult<Api>(data);
            }

            return new ErrorDataResult<Api>();
        }

        public IResult Update(Api api)
        {
            IResult result = BusinessRules.Run(CheckApiExist(api));

            if (result == null)
            {
                var existEntity = _apiDal.GetAll().Where(c => c.Id == 1).FirstOrDefault();

                if (existEntity != null)
                {
                    api.Id = existEntity.Id;

                    _apiDal.Update(api);

                    return new SuccessResult(Messages.ApiUpdated);
                }
            }

            this.Add(api);

            return new SuccessResult(Messages.ApiUpdated);
        }

        private IResult CheckApiExist(Api api)
        {
            if (api != null)
            {
                var data = _apiDal.GetAll();

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
