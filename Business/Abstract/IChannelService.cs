using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IChannelService
    {
        IDataResult<Channel> Get();
        IDataResult<List<Channel>> GetAll();
        IResult Add(Channel channel);
        IResult Update(Channel channel);
    }
}
