using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
        readonly IChannelDal _channelDal;

        public ChannelManager(IChannelDal channelDal)
        {
            _channelDal = channelDal;
        }

        public IResult Add(Channel channel)
        {
            IResult result = BusinessRules.Run(CheckChannelExist(channel));

            if (result != null)
            {
                _channelDal.Update(channel);
            }

            _channelDal.Add(channel);

            return new SuccessResult(Messages.ChannelAdded);
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

        private IResult CheckChannelExist(Channel channel)
        {
            var result = _channelDal.GetAll(c => c == channel).Any();

            if (result)
            {
                return new ErrorResult(Messages.ItsAlreadyExist);
            }

            return new SuccessResult();
        }
    }
}
