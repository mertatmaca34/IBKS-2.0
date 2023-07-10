using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISendDataService
    {
        IResult Add(SendData sendData);
        IResult Delete(SendData sendData);
        IResult Update(SendData sendData);
        IDataResult<List<SendData>> GetAll();
    }
}
