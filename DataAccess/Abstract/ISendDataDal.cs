using Core.DataAccess;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ISendDataDal : IEntityRepository<SendData>
    {
        List<SendData> GetUnsentBatch(int batchSize, int lastProcessedId);
    }
}
