using Core.Entities;

namespace Entities.Concrete
{
    public class Channel : IEntity
    {
        public int Id { get; set; }
        public bool DesarjDebiRead { get; set; }
        public bool DesarjDebiSend { get; set; }
        public bool HariciDebiRead { get; set; }
        public bool HariciDebiSend { get; set; }
        public bool HariciDebi2Read { get; set; }
        public bool HariciDebi2Send { get; set; }
    }
}
