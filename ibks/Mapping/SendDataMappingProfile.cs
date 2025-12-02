using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ibks.Mapping
{
    public class SendDataMappingProfile : Profile
    {
        public SendDataMappingProfile()
        {
            CreateMap<SendDataResult, SendData>();
        }
    }

}
