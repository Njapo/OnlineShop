using OnlineShop_Web.Models;

namespace OnlineShop_Web.Services.IServices
{
    public interface IItemService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> GetByNameAsync<T>(string name);
        Task<T> CreateAsync<T>(ItemCreateDTO dto, string token);
        Task<T> UpdateAsync<T>(ItemUpdateDTO dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
