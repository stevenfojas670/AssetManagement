using AssetManagement.Core.IServices;
using AssetManagement.UseCase.DTOs;

namespace AssetManagement.UseCase.UseCases.User
{
    public class CreateUserUseCase
    {
        private readonly IUserService _userService;

        public CreateUserUseCase(IUserService userService)
        {
            _userService = userService;
        }

        public async Task ExecuteAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
