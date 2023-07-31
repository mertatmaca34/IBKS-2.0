namespace Entities.Concrete.API
{
    public class SendCalibration
    {
        public DateTime? CalibrationDate { get; set; }
        public Guid? Stationid { get; set; }
        public string DBColumnName { get; set; }
        public double? ZeroRef { get; set; }
        public double? ZeroMeas { get; set; }
        public double? ZeroDiff { get; set; }
        public double? ZeroSTD { get; set; }
        public double? SpanRef { get; set; }
        public double? SpanMeas { get; set; }
        public double? SpanDiff { get; set; }
        public double? SpanSTD { get; set; }
        public double? ResultFactor { get; set; }
        public bool? ResultZero { get; set; }
        public bool? ResultSpan { get; set; }
    }
}
