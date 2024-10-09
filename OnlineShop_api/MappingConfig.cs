using AutoMapper;
using OnlineShop_api.Models;

namespace OnlineShop_api
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Item,ItemDTO>().ReverseMap();
            CreateMap<Item, ItemCreateDTO>().ReverseMap();
            CreateMap<Item, ItemUpdateDTO>().ReverseMap();

        }
    }
}
