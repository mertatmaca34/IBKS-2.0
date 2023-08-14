using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISampleService
    {
        IResult Add(Sample sample);
        IDataResult<List<Sample>> GetAll(Expression<Func<Sample, bool>> filter = null);
    }
}
