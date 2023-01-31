
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LibraryApp.Pages
{
    public class LibraryIndexModel : PageModel
    {
        private readonly ILogger<LibraryIndexModel> _logger;

        public LibraryIndexModel(ILogger<LibraryIndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}