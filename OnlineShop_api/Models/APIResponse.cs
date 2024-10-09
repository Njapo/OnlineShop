using System.Net;

namespace OnlineShop_api.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess{ get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
