using Users.Registration.Domain.Abstractions.Users;
using Users.Registration.Domain.Entities.Frameworks;
using Users.Registration.Domain.Entities.Users;

namespace Users.Registration.Infrastructure.Repositories.Users
{
    public class UserFromInMemoryRepositoryImpl : IUserRepository
    {
        public Result<List<UserData>> GetAll()
        {
            Result<List<UserData>> result = new Result<List<UserData>>();
            if(GetUsers()?.Count > 0)
            {
                result.Code = ResultCodes.Ok;
                result.Message = "SUCCESS";
                result.Entity = GetUsers();
            }
            else
            {
                result.Code = ResultCodes.UserNotFound;
                result.Message = "Users data not found.";
            }
            return result;
        }

        public Result<UserData> GetById(long Id)
        {
            Result<UserData> result = new Result<UserData>();
            var userData = GetUsers().FirstOrDefault(w => w.Id == Id);
            if(userData != null)
            {
                result.Code = ResultCodes.Ok;
                result.Message = "SUCCESS";
                result.Entity = userData;
            }
            else
            {
                result.Code = ResultCodes.UserNotFound;
                result.Message = "User data not found.";
            }
            return result;
        }

        private List<UserData> GetUsers()
        {
            List<UserData> usersData = new List<UserData>()
            {
                new UserData() { Id = 1, FirstName = "Иван", LastName = "Иванов", MiddleName = "Иванович", Age = 20},
                new UserData() { Id = 2, FirstName = "Александр", LastName = "Сергеев", MiddleName = "Александрович", Age = 25},
                new UserData() { Id = 3, FirstName = "Петр", LastName = "Васильев", MiddleName = "Петорович", Age = 35}
            };
            return usersData;
        }
    }
}