using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISampleService
    {
        IResult Add(Sample sample);
        IDataResult<List<Sample>> GetAll();
    }
}
