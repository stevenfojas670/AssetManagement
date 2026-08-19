using AssetManagement.Core.Entities;

namespace AssetManagement.Core.IServices
{
    public interface IUserService
    {
        Task<UserEntity> CreateUserAsync(UserEntity user);
    }
}
