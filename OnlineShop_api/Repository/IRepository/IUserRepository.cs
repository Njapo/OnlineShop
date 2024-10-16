using OnlineShop_api.Models;
using OnlineShop_api.Models.Dto;

namespace OnlineShop_api.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequstDTO registrationRequstDTO);
    }
}
