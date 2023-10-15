using Users.Registration.Application.Dto.Users;
using Users.Registration.Domain.Entities.Frameworks;

namespace Users.Registration.Application.Services.Users
{
    public interface IUserService
    {
        public Result<List<UserDataDto>> GetAll();
        public Result<UserDataDto> GetById(long Id);
    }
}