using Microsoft.AspNetCore.Mvc;
using Users.Registration.Application.Dto.Users;
using Users.Registration.Application.Services.Users;
using Users.Registration.Domain.Entities.Frameworks;

namespace Users.Registration.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Получает список всех пользователей
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllUsers")]
        public Result<List<UserDataDto>> GetAll()
        {
            return userService.GetAll();
        }

        /// <summary>
        /// Получает пользователя по идентификатору
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserById/{Id}")]
        public Result<UserDataDto> GetById(long Id)
        {
            return userService.GetById(Id);
        }
    }
}