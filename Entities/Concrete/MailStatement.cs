using Core.Entities;

namespace Entities.Concrete
{
    public class MailStatement : IEntity
    {
        public int Id { get; set; }
        public required string StatementName { get; set; }
        public required string Parameter { get; set; }
        public required string Statement { get; set; }
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        public TimeSpan CoolDown { get; set; }
    }
}
