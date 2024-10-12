using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop_Web.Models;
using OnlineShop_Web.Services.IServices;

namespace OnlineShop_Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;
        public ItemController(IItemService itemService,IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexItem()
        {
            List<ItemDTO> items = new();
            var response = await _itemService.GetAllAsync<APIResponse>();
            if(response != null && response.IsSuccess) {
                items=JsonConvert.DeserializeObject<List<ItemDTO>>(Convert.ToString(response.Result));
            }
            return View(items);
        }

        public async Task<IActionResult> CreateItem()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateItem(ItemCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _itemService.CreateAsync<APIResponse>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexItem));
                }
            }
            return View(model);
        }

    }
}
