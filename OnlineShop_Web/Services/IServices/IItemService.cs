using OnlineShop_Web.Models;

namespace OnlineShop_Web.Services.IServices
{
    public interface IItemService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(ItemCreateDTO dto);
        Task<T> UpdateAsync<T>(ItemUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
