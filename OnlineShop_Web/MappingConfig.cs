using AutoMapper;
using OnlineShop_Web.Models;

namespace OnlineShop_api
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ItemDTO, ItemCreateDTO>().ReverseMap();
            CreateMap<ItemDTO, ItemUpdateDTO>().ReverseMap();

        }
    }
}
