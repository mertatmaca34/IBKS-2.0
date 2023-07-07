using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class ChannelManager : IChannelService
    {
        IChannelDal _channelDal;

        public ChannelManager(IChannelDal channelDal)
        {
            _channelDal = channelDal;
        }

        public IResult Add(Channel channel)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Channel channel)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Channel> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Channel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Channel channel)
        {
            throw new NotImplementedException();
        }
    }
}
