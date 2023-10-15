using AutoMapper;
using Users.Registration.Application.Dto.Users;
using Users.Registration.Domain.Abstractions.Users;
using Users.Registration.Domain.Entities.Frameworks;

namespace Users.Registration.Application.Services.Users
{
    public class UserService : IUserService
    {
        private IMapper mapper;
        private IUserRepository userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public Result<List<UserDataDto>> GetAll()
        {
            Result<List<UserDataDto>> result = new Result<List<UserDataDto>>();
            try
            {
                var usersResult = userRepository.GetAll();
                List<UserDataDto> userList = 
                    mapper.Map<List<UserDataDto>>(usersResult.Entity);

                result.Code = usersResult.Code;
                result.Message = usersResult.Message;
                result.Entity = userList;
            }
            catch(Exception ex)
            {
                result.Code = ResultCodes.GenericError;
                result.Message = $"{ex.GetType} [{ex}]";
            }
            return result;
        }

        public Result<UserDataDto> GetById(long Id)
        {
            Result<UserDataDto> result = new Result<UserDataDto>();
            try
            {
                var resultUser = userRepository.GetById(Id);
                result.Code = resultUser.Code;
                result.Message = resultUser.Message;
                result.Entity = mapper.Map<UserDataDto>(resultUser.Entity);
            }
            catch(Exception ex)
            {
                result.Code = ResultCodes.GenericError;
                result.Message = $"{ex.GetType} [{ex}]";
            }
            return result;
        }
    }
}