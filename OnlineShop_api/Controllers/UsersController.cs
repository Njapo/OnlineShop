using Microsoft.AspNetCore.Mvc;
using OnlineShop_api.Models;
using OnlineShop_api.Models.Dto;
using OnlineShop_api.Repository.IRepository;
using System.Net;

namespace OnlineShop_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        protected APIResponse _response;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            this._response = new();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequestDTO model)
        {
            var loginResponse = await _userRepository.Login(model);
            if (loginResponse == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _response.ErrorMessages = new List<string>() { "Username or Password is incorrect" };
                _response.IsSuccess = false;
                _response.StatusCode=HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequstDTO model)
        {
            bool isUniqueUser = _userRepository.IsUniqueUser(model.UserName);
            if (!isUniqueUser)
            {
                _response.ErrorMessages = new List<string>() { "Username Already Exists" };
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            var user=await _userRepository.Register(model);
            if (user == null)
            {
                _response.ErrorMessages = new List<string>() { "Error while registering" };
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }

            return Ok(_response);
        }
    }
}
