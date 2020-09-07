using System;
using System.Linq;
using Library.Domain.DTOs;
using Library.Domain.Interfaces;
using Library.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace LB_Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser) =>
            _serviceUser = serviceUser;

        [HttpPost]
        public IActionResult Register([FromBody] UserModel userModel)
        {
            try
            {
                var user = _serviceUser.Insert(userModel);

                return Ok(user?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDto user)
        {
            try
            {
                var users = _serviceUser.RecoverAll();

                if (users.FirstOrDefault(x => x.Name == user.Name && x.Password == user.Password) != null)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                var users = _serviceUser.RecoverAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                var user = _serviceUser.RecoverById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UserModelUpdate userModel)
        {
            try
            {
                var user = _serviceUser.Update(id, userModel);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _serviceUser.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
