using AssetManagement.Core.Entities;
using AssetManagement.Core.IServices;

namespace AssetManagement.Core.Services
{
    public class UserService : IUserService
    {
        public Task<UserEntity> CreateUserAsync(UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
