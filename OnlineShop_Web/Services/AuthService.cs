using OnlineShop_Utility;
using OnlineShop_Web.Models;
using OnlineShop_Web.Models.Dto;
using OnlineShop_Web.Services.IServices;

namespace OnlineShop_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string itemUrl;
        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            this.itemUrl = configuration.GetValue<string>("ServiceUrls:OnlineShopAPI");

        }
        public Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = itemUrl + "/api/Users/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegistrationRequstDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = itemUrl + "/api/Users/register"
            });
        }
    }
}
