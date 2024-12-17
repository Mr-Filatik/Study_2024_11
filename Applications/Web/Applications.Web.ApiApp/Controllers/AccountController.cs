﻿using Applications.Web.ApiApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using Shared.Database.MainDatabase.Repositories;
using Swashbuckle.AspNetCore.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace Applications.Web.ApiApp.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public AccountController(UserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _configuration = config;
        }

        [AllowAnonymous]
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
                        Token = GenerateToken(request.Login)
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
            var id = User.FindFirst(ClaimTypes.Name);
            if (id == null)
            {
                return string.Empty;
            }
            return $"{id.Value}";
        }

        [HttpGet]
        [Route("second-name")]
        public string GetSecondName()
        {
            return "BBB";
        }

        private string GenerateToken(string userId)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, userId),
            };
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                expires: DateTime.UtcNow.AddMinutes(5),
                claims: claims,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"])), SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
