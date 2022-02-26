namespace PPMV2.Web.Utility
{
    public class Utility
    {

    }
    public class Response
    {
        public bool IsError { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Response<T> : Response
    {
        public T obj { get; set; }
    }
}
