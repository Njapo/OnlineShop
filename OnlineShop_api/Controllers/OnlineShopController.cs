using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineShop_api.Data;
using OnlineShop_api.logs.Logging;
using OnlineShop_api.Models;
using OnlineShop_api.Repository.IRepository;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using OnlineShop_api.Enums;

namespace OnlineShop_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineShopController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IItemRepository _dbItem;
        private readonly IMapper _mapper;
        private readonly ILogging _logger;
        public OnlineShopController(ILogging logger, IItemRepository dbItem, IMapper mapper)
        {
            _mapper = mapper;
            _dbItem = dbItem;
            _logger = logger;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetItems()
        {
            try
            {
                IEnumerable<Item> items = await _dbItem.GetAll();
                _response.Result = _mapper.Map<List<ItemDTO>>(items);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                APIResponse.FailedResponse(_response, ex);
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetItem(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.ErrorMessages = new List<string>() { "There is no Item at 0 ID" };
                    return BadRequest(_response);
                }
                var item = await _dbItem.Get(it => it.Id == id);
                if (item == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<ItemDTO>(item);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                APIResponse.FailedResponse(_response, ex);
            }
            return _response;
        }
        
        [HttpPost]
        [Authorize(Roles ="Admin,Moderator" )]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<APIResponse>> CreateItem([FromBody] ItemCreateDTO itemCreate)
        {
            try
            {
                if (itemCreate == null)
                {
                    return BadRequest(itemCreate);
                }
                if(await _dbItem.Get(it => it.Name.ToLower() == itemCreate.Name.ToLower()) != null)
                {
                    _response.ErrorMessages = new List<string>() { "This Item already exists!!!" };
                    _response.StatusCode = HttpStatusCode.Conflict;
                    _response.IsSuccess = false;
                    return Conflict(_response);
                }
                Item item=_mapper.Map<Item>(itemCreate);
                await _dbItem.Create(item);
                _response.StatusCode = HttpStatusCode.Created;
                _response.Result=_mapper.Map<ItemDTO>(item);
                _response.IsSuccess=true;
                return CreatedAtRoute("GetItem",new {id=item.Id},_response);
            }
            catch(Exception ex)
            {
                APIResponse.FailedResponse(_response, ex);
            }
            return _response;
        }

        [HttpDelete("{id:int}",Name ="DeleteItem")]
        [Authorize(Roles = "Admin,Moderator")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeleteItem(int id)
        {
            try
            {
                if(id == 0)
                {
                    _response.ErrorMessages = new List<string>() { "There is no Item at 0 ID" };
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var item=await _dbItem.Get(it=>it.Id==id);
                if(item == null)
                {
                    _response.ErrorMessages = new List<string>() { "Item was not found" };
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    return NotFound(_response);
                }
                await _dbItem.Remove(item);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                APIResponse.FailedResponse (_response, ex);
            }
            return _response;
        }

        [HttpPut("{id:int}",Name ="UpdateItem")]
        [Authorize(Roles = "Admin,Moderator")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateItem(int id, [FromBody]ItemUpdateDTO itemUpdate)
        {
            try
            {
                if (id == 0 || itemUpdate == null)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode=HttpStatusCode.BadRequest;
                    _response.ErrorMessages = new List<string>() { "id and Item can not be null" };
                    return BadRequest(_response);
                }
                Item item=_mapper.Map<Item>(itemUpdate);
                await _dbItem.Update(item);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch(Exception ex)
            {
                APIResponse.FailedResponse(_response, ex);
            }
            return _response;
        }

        [HttpPatch("{id:int}",Name ="UpdatePartialItem")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdatePartialItem(int id,JsonPatchDocument<ItemUpdateDTO> itemPatch)
        {
            try
            {
                if(id == 0 || itemPatch == null)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode=HttpStatusCode.BadRequest;
                    _response.ErrorMessages = new List<string>() { "id and item can not be null" };
                }
                var item=await _dbItem.Get(it=>it.Id==id,tracked:false);
                if(item == null)
                {
                    return BadRequest();
                }
                var updateItem=_mapper.Map<ItemUpdateDTO>(item);
                itemPatch.ApplyTo(updateItem, ModelState);
                var model=_mapper.Map<Item>(updateItem);
                await _dbItem.Update(model);
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess=true;
                return NoContent();

            }catch(Exception ex)
            {
                APIResponse.FailedResponse(_response,ex);   
            }
            return _response;
        }
    }
}
