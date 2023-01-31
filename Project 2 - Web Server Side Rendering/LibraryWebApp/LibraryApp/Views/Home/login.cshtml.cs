
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LibraryApp.Pages
{
    public class loginModel : PageModel
    {
        private readonly ILogger<loginModel> _logger;

        public loginModel(ILogger<loginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}