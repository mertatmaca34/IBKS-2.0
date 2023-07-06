using Core.Entities;

namespace Entities.Concrete
{
    public class Calibration : IEntity
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Parameter { get; set; }
        public double ZeroRef { get; set; }
        public double ZeroMeas { get; set; }
        public double ZeroDiff { get; set; }
        public double ZeroStd { get; set; }
        public double SpanRef { get; set; }
        public double SpanMeas { get; set; }
        public double SpanDiff { get; set; }
        public double SpanStd { get; set; }
        public double ResultFactor { get; set; }
        public bool IsItValid { get; set; }
    }
}
