using Users.Registration.Domain.Entities.Frameworks;
using Users.Registration.Domain.Entities.Users;

namespace Users.Registration.Domain.Abstractions.Users
{
    public interface IUserRepository
    {
        public Result<List<UserData>> GetAll();
        public Result<UserData> GetById(long Id);
    }
}