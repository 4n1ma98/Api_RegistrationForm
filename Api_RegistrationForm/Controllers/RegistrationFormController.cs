using Business.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;

namespace Api_RegistrationForm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationFormController : ControllerBase
    {
        private readonly IUserValidation _userValidation;

        public RegistrationFormController(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        [HttpPost("[action]")]
        public IActionResult CreateUser(CreateUserRequest request)
        {
            _userValidation.Create_User(request);
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetUsers()
        {
            return Ok(_userValidation.Get_Users());
        }
    }
}
