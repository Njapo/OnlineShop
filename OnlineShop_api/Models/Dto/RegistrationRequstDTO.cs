using OnlineShop_api.Enums;

namespace OnlineShop_api.Models.Dto
{
    public class RegistrationRequstDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
