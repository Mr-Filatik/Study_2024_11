using Applications.Web.ApiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Database.MainDatabase.Repositories;
using Swashbuckle.AspNetCore.Filters;

namespace Applications.Web.ApiApp.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        [ProducesResponseType<LoginResponse>(StatusCodes.Status200OK)]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status400BadRequest)]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status500InternalServerError)]
        [SwaggerRequestExample(typeof(LoginRequest), typeof(LoginRequestExample))]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                if (request.Login == "Vlad")
                {
                    return Ok(new LoginResponse()
                    {
                        Token = $"hello {_userRepository.Get(1)?.Email}"
                    });
                }

                return BadRequest(new ErrorResponse()
                {
                    Message = "User not found"
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new ErrorResponse()
                {
                    Message = "Unexpected error"
                });
            }
        }

        [HttpGet("getname/{login}")]
        public string GetName(string login)
        {
            return $"AAA{login}";
        }

        [HttpGet]
        [Route("second-name")]
        public string GetSecondName()
        {
            return "BBB";
        }
    }
}
