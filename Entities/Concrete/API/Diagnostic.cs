namespace Entities.Concrete.API
{
    public class Diagnostic
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public Guid stationId { get; set; }
        public string details { get; set; }
        public int? diagnosticTypeNo { get; set; }
    }
}
