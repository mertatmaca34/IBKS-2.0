using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete.API;
using Newtonsoft.Json;
using IResult = Core.Utilities.Results.IResult;

namespace WebAPI.Utils
{
    public static class Assigns
    {
        public static IResult AssignHttpClient(IApiService apiManager, string apiBaseUrl, HttpClient httpClient)
        {
            var apiData = apiManager.Get();
            if (apiData.Success)
            {
                apiBaseUrl = apiData.Data.ApiAdress;

                httpClient.BaseAddress = new Uri(apiBaseUrl);
                httpClient.DefaultRequestHeaders.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = Constants.Constants.TicketId.ToString()! }));

                return new SuccessResult();
            }

            return new ErrorResult(Messages.DataNotFound);
        }
    }
}
