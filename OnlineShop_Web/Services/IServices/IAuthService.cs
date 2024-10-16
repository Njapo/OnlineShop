using OnlineShop_Web.Models.Dto;

namespace OnlineShop_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegistrationRequstDTO objToCreate);

    }
}
