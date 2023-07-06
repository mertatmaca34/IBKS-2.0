using Core.Entities;

namespace Entities.Concrete
{
    public class Sample : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string SampleCode { get; set; }
        public string SampleType { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string LastState { get; set; }
        public string Sampler { get; set; }
    }
}
