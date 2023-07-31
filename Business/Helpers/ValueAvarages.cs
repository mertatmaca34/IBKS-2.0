using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Helpers
{
    public static class ValueAvarages
    {
        public static IDataResult<DB41> Last60MinAvg(ISendDataService sendDataManager)
        {
            var data = sendDataManager.GetLast60Minutes();

            if (data.Success && data.Data != null && data.Data.Count > 1)
            {
                var avgData = new DB41
                {
                    Akm = Math.Round(data.Data.Average(d => d.AKM), 2),
                    CozunmusOksijen = Math.Round(data.Data.Average(d => d.CozunmusOksijen), 2),
                    KabinSicaklik = Math.Round(data.Data.Average(d => d.Sicaklik), 2),
                    Ph = Math.Round(data.Data.Average(d => d.pH), 2),
                    Iletkenlik = Math.Round(data.Data.Average(d => d.Iletkenlik), 2),
                    Koi = Math.Round(data.Data.Average(d => d.KOi), 2),
                    NumuneHiz = Math.Round(data.Data.Average(d => d.AkisHizi), 2),
                    TesisDebi = Math.Round(data.Data.Average(d => d.Debi), 2)
                };

                return new SuccessDataResult<DB41>(avgData);
            }
            else
            {
                return null;
            }
        }
    }
}

