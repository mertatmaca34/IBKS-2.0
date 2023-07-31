using API.Abstract;
using API.Enums;
using API.Models;
using Entities.Concrete;
using Entities.Concrete.API;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace API.Service
{
    public class APIService : IApiConnection
    {
        private string Url { get; set; }
        private Guid? TicketId { get; set; }
        private StationInformation StationInfo { get; set; }
        private StationType stationType { get; set; }

        public APIService()
        {
            stationType = StationType.SAIS;
            Url = "https://entegrationsais.csb.gov.tr/";
        }

        private string MD5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private ResultStatus<T> PostData<T>(string url, string data) where T : new()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    webClient.Headers.Add("AToken", JsonConvert.SerializeObject(new AToken { TicketId = this.TicketId.ToString() }));

                    var fullUrl = this.Url + url;
                    var queryString = data;

                    var queryUrl = fullUrl;
                    if (!string.IsNullOrEmpty(queryString))
                        queryUrl += "?" + queryString;

                    var resp = webClient.UploadString(fullUrl, queryString);
                    return JsonConvert.DeserializeObject<ResultStatus<T>>(resp);
                }
            }
            catch (Exception ex)
            {
                return new ResultStatus<T>
                {
                    message = ex.Message + Environment.NewLine + url
                };
            }
        }

        public ResultStatus<LoginResult> Login(string username, string password)
        {
            var login = new Login
            {
                username = username,
                password = MD5Hash(MD5Hash(password))
            };

            var res = PostData<LoginResult>("/security/login", JsonConvert.SerializeObject(login));
            if (res.result)
            {
                this.TicketId = res.objects.TicketId.Value;
            }

            return res;
        }

        public ResultStatus<object> SendData(SendData data)
        {
            var res = PostData<object>(this.stationType.ToString() + "/SendData", JsonConvert.SerializeObject(data));

            return res;
        }
        private ResultStatus<T> TriggerService<T>(string url) where T : new()
        {
            try
            {
                var _url = String.Format("https://{0}:{1}/{2}", StationInfo.ConnectionDomainAddress, StationInfo.ConnectionPort, url);

                using (var webClient = new WebClient())
                {

                    webClient.Encoding = Encoding.UTF8;
                    webClient.UseDefaultCredentials = true;
                    webClient.Credentials = new NetworkCredential(StationInfo.ConnectionUser, StationInfo.ConnectionPassword);

                    var resp = webClient.DownloadString(_url);

                    return JsonConvert.DeserializeObject<ResultStatus<T>>(resp);
                }

            }
            catch (Exception ex)
            {
                return new ResultStatus<T>
                {
                    message = ex.Message + System.Environment.NewLine + url
                };
            }
        }
        public ResultStatus<DateTime> Trigger_GetLastDataDate()
        {
            var res = TriggerService<DateTime>(String.Format("GetLastDataDate?StationId={0}", StationInfo.StationId));

            return res;
        }



        public ResultStatus<StationInformation> GetStationInformation(string stationId)
        {

            var res = PostData<StationInformation>(String.Format(this.stationType.ToString() + "/GetStationInformation?stationId={0}", stationId), "");
            if (res.result)
            {
                this.StationInfo = res.objects;
            }

            return res;

        }

        public ResultStatus<object> SendHostChanged(StationInformation data)
        {
            var res = PostData<object>(this.stationType.ToString() + "/SendHostChanged", JsonConvert.SerializeObject(data));

            return res;
        }

        public ResultStatus<object> GetLastData(GetLastData getLastData)
        {
            var res = PostData<object>(this.stationType.ToString() + "/GetLastData", JsonConvert.SerializeObject(getLastData));

            return res;
        }

        public ResultStatus<object> SampleRequestStart(SendData data)
        {
            var res = PostData<object>(this.stationType.ToString() + "/SampleRequestStart", JsonConvert.SerializeObject(data));

            return res;
        }

        public ResultStatus<object> SendCalibration(SendCalibration data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendCalibration", JsonConvert.SerializeObject(data));

            return res;

        }
        public ResultStatus<List<DiagnosticType>> GetDiagnosticTypes()
        {

            var res = PostData<List<DiagnosticType>>(this.stationType.ToString() + "/GetDiagnosticTypes", "");

            return res;

        }
        public ResultStatus<object> SendDiagnostic(Diagnostic data)
        {

            var res = PostData<object>(this.stationType.ToString() + "/SendDiagnostic", JsonConvert.SerializeObject(data));

            return res;

        }
    }
}
