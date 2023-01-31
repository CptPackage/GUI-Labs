
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LibraryApp.Pages
{
    public class signUpModel : PageModel
    {
        private readonly ILogger<signUpModel> _logger;

        public signUpModel(ILogger<signUpModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}