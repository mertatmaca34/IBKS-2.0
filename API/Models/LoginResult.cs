using System;

namespace API.Models
{
    public class LoginResult
    {
        public Guid? TicketId { get; set; }
        public Guid? DeviceId { get; set; }
        public SH_User User { get; set; }
    }
    public class SH_User
    {
        public object idcode { get; set; }
        public int type { get; set; }
        public string loginname { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthday { get; set; }
        public string password { get; set; }
        public string title { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cellphone { get; set; }
        public string address { get; set; }
        public bool status { get; set; }
        public string city { get; set; }
        public string town { get; set; }
        public string tckimlikno { get; set; }
        public object DutyCity { get; set; }
        public DateTime ExpireDate { get; set; }
        public string City_Title { get; set; }
        public string Town_Title { get; set; }
        public object DutyCity_Title { get; set; }
        public string createdby_Title { get; set; }
        public string changedby_Title { get; set; }
        public object CompanyId { get; set; }
        public object Company_Title { get; set; }
        public string FullName { get; set; }
        public string Status_Title { get; set; }
        public string Type_Title { get; set; }
        public object PositionName_Title { get; set; }
        public string Roles_Title { get; set; }
        public string id { get; set; }
        public DateTime created { get; set; }
        public DateTime changed { get; set; }
        public string changedby { get; set; }
        public string createdby { get; set; }
    }
}
