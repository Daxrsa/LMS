namespace Application.Core
{
    public class ServiceResponse<T> 
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }

        public static ServiceResponse<T> IsSuccess(T value) => new ServiceResponse<T> {Success = true, Data = value};
        public static ServiceResponse<T> Failure(string error) => new ServiceResponse<T> {Success = false, Message = error};
    }
}