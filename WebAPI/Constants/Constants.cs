using Business.Concrete;

namespace WebAPI.Constants
{
    public static class Constants
    {
        public static HttpClient HttpClient = new HttpClient();
        public static Guid? TicketId { get; set; }
    }
}
