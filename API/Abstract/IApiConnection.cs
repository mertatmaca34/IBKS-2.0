using API.Models;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Abstract
{
    public interface IApiConnection 
    {
        ResultStatus<object> SendData(SendData sendData);
    }
}
