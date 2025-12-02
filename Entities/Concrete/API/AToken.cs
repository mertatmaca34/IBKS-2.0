namespace Entities.Concrete.API
{
    public class AToken
    {
        public Guid? TicketId { get; set; }
        public Guid? DeviceId { get; set; }
        public DateTime Expiration { get; set; }
    }
}
