using Core.Entities;

namespace Entities.Concrete
{
    public class Sample : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public required string SampleCode { get; set; }
        public required string SampleType { get; set; }
        public required string PlaceOfDelivery { get; set; }
        public required string LastState { get; set; }
        public required string Sampler { get; set; }
    }
}
