using Core.Utilities.Results;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISendDataService
    {
        IResult Add(SendData sendData);
        IResult Delete(SendData sendData);
        IResult Update(SendData sendData);
        IDataResult<List<SendData>> GetAll(Expression<Func<SendData, bool>> filter = null);
        IDataResult<List<SendData>> GetLast60Minutes();
        IDataResult<List<SendData>> GetLastWashTime();
        IDataResult<List<SendData>> GetLastWashWeekTime();
    }
}
