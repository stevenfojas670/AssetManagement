using AssetManagement.UseCase.DTOs;
using AssetManagement.UseCase.UseCases.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AssetManagement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CreateUserUseCase _createUserUseCase;

        public IndexModel(CreateUserUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        [BindProperty]
        public UserDTO User { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostNewUserAsync()
        {
            return new JsonResult(new { success = true });
        }
    }
}
