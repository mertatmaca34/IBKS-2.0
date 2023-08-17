namespace Entities.Concrete.API
{
    public class MissingDate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DateTime>? MissingDates { get; set; }
    }
}
