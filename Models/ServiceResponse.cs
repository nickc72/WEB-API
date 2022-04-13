namespace WEB_API.Models
{
    //It wraps up the object and send it to the client with the success or failure message
    //Represents the standard response to an Exchange Web Services operation.
    public class ServiceResponse<T>
    {
        public  T  Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } =null;
    }
}