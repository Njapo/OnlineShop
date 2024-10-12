using System.Net;

namespace OnlineShop_api.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public static void FailedResponse(APIResponse response, Exception ex)
        {
            response.IsSuccess = false;
            response.ErrorMessages = new List<string>() { ex.Message };
        }
    }
}
