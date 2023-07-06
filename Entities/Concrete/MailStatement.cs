using Core.Entities;

namespace Entities.Concrete
{
    public class MailStatement : IEntity
    {
        public int Id { get; set; }
        public string StatementName { get; set; }
        public string Parameter { get; set; }
        public string Statement { get; set; }
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        public TimeSpan CoolDown { get; set; }
    }
}
