//using AspNetCore;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop_Utility;
using OnlineShop_Web.Models;
using OnlineShop_Web.Services.IServices;
using System.Reflection;

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

        [HttpGet]
        public async Task<IActionResult> GetItem(int id)
        {
            var response = await _itemService.GetAsync<APIResponse>(id);
            var item = JsonConvert.DeserializeObject<ItemDTO>(Convert.ToString(response.Result));
            if (item == null)
            {
               return RedirectToAction(nameof(IndexItem));
            }

            return View(item);
        }

        [HttpGet("Item/GetItemsByName")]
        public async Task<IActionResult> GetItemByName(string name)
        {
            var response=await _itemService.GetByNameAsync<APIResponse>(name);
            var items = JsonConvert.DeserializeObject<List<ItemDTO>>(Convert.ToString(response.Result));
            if(items != null)
            {
                return View("IndexItem", items);
            }
            return RedirectToAction(nameof(IndexItem));
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
                var response = await _itemService.CreateAsync<APIResponse>(model,HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexItem));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateItem(int itemId)
        {
            var response = await _itemService.GetAsync<APIResponse>(itemId);
            if (response != null && response.IsSuccess)
            {
                ItemDTO model=JsonConvert.DeserializeObject<ItemDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<ItemUpdateDTO>(model));
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateItem(ItemUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _itemService.UpdateAsync<APIResponse>(model, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexItem));
                }
            }
            return View(model);
        }


        public async Task<IActionResult> DeleteItem(int itemId)
        {
            var response = await _itemService.GetAsync<APIResponse>(itemId);
            if (response != null && response.IsSuccess)
            {
                ItemDTO model = JsonConvert.DeserializeObject<ItemDTO>(Convert.ToString(response.Result));
                await _itemService.DeleteAsync<APIResponse>(model.Id, HttpContext.Session.GetString(SD.SessionToken));
                
                return RedirectToAction(nameof(IndexItem));
            }
            return NotFound();
        }

    }
}
