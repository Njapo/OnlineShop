using OnlineShop_Utility;
using OnlineShop_Web.Models;
using OnlineShop_Web.Services.IServices;

namespace OnlineShop_Web.Services
{
    public class ItemService : BaseService, IItemService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string itemUrl;
        public ItemService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            itemUrl = configuration.GetValue<string>("ServiceUrls:OnlineShopAPI");
        }
        public Task<T> CreateAsync<T>(ItemCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = itemUrl + "/api/OnlineShop",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = itemUrl + "/api/OnlineShop/" + id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = itemUrl + "/api/OnlineShop"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = itemUrl + "/api/OnlineShop/"+id
            });
        }

        public Task<T> GetByNameAsync<T>(string name)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = itemUrl + $"/api/OnlineShop/search?name={name}"
            });
        }

        public Task<T> UpdateAsync<T>(ItemUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = itemUrl + "/api/OnlineShop/"+dto.Id,
                Token = token
            });
        }
    }
}
