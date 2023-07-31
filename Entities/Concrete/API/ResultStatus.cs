namespace Entities.Concrete.API
{
    public class ResultStatus
    {
        public bool result { get; set; }
        public string message { get; set; }
        public object objects { get; set; }
    }

    public class ResultStatus<T>
    {
        public bool result { get; set; }
        public string message { get; set; }
        public T objects { get; set; }
    }
}
