using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSendDataDal : EfEntityRepositoryBase<SendData, IBKSContext>, ISendDataDal
    {
        public List<SendData> GetUnsentBatch(int batchSize, int lastProcessedId)
        {
            using var context = new IBKSContext();

            return context.Set<SendData>()
                .AsNoTracking()
                .Where(x => (x.IsSent == false || x.IsSent == null) && x.Id > lastProcessedId)
                .OrderBy(x => x.Id)
                .Take(batchSize)
                .ToList();
        }
    }
}
