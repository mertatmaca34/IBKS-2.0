using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISendDataService
    {
        IResult Add(SendData sendData);
        IResult Delete(SendData sendData);
        IResult Update(SendData sendData);
        IDataResult<List<SendData>> GetAll();
        IDataResult<List<SendData>> GetLast60Minutes();
        IDataResult<List<SendData>> GetLastWashTime();
        IDataResult<List<SendData>> GetLastWeeklyWashTime();
    }
}
