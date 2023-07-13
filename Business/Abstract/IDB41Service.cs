using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDB41Service
    {
        IResult Add(DB41 dB41);
        IResult Delete(DB41 dB41);
        IResult Update(DB41 dB41);
        IDataResult<List<DB41>> GetAll();
    }
}
