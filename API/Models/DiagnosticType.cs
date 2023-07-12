namespace API.Models
{
    public class DiagnosticType
    {
        public int DiagnosticTypeNo { get; set; }
        public string DiagnosticTypeName { get; set; }
        public int? DiagnosticLevel { get; set; }
        public string DiagnosticLevel_Title { get; set; }
    }
}
