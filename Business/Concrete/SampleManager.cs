using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SampleManager : ISampleService
    {
        ISampleDal _sampleDal;
        public SampleManager(ISampleDal sampleDal)
        {
            _sampleDal = sampleDal;
        }

        public IResult Add(Sample sample)
        {
            IResult result = BusinessRules.Run(CheckSampleExist(sample));

            if (result != null)
            {
                _sampleDal.Update(sample);

                return new SuccessResult(Messages.SampleUpdated);
            }

            _sampleDal.Add(sample);

            return new SuccessResult(Messages.SampleAdded);
        }

        public IDataResult<List<Sample>> GetAll()
        {
            return new SuccessDataResult<List<Sample>>(_sampleDal.GetAll());
        }

        private IResult CheckSampleExist(Sample sample)
        {
            var result = _sampleDal.GetAll(s => s == sample).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
