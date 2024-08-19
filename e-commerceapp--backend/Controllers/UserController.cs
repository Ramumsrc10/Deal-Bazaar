using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Entities;
using PracticeAPI.Repositories;
using PracticeAPI.Models;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly IConfiguration configuration;

        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            this.userRepository = userRepository;
            this.configuration = configuration;
        }

        [HttpPost, Route("RegisterUser")]
        [AllowAnonymous]

        public IActionResult RegisterUser(User user)
        {
            try
            {
                userRepository.Register(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut, Route("EditUser")]
        public IActionResult EditUser(User user)
        {
            try
            {
                userRepository.EditProfile(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut, Route("ChangePassword/{userId}/{oldpwd}/{newpwd}")]
        public IActionResult ChangePassword(string userId, string oldpwd, string newpwd)
        {
            try
            {
                userRepository.ChangePassword(userId, oldpwd, newpwd);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route("Validate")]
        [AllowAnonymous]
        public IActionResult Validate(Login login)
        {
            try
            {
                User user = userRepository.Login(login.Email, login.Password);
                JsonResponse jsonResponse = new JsonResponse();
                if (user != null)
                {
                    jsonResponse.UserId = user.UserId;
                    jsonResponse.Name = user.Name;
                    jsonResponse.Role = user.Role;
                }
                return StatusCode(200, jsonResponse);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
