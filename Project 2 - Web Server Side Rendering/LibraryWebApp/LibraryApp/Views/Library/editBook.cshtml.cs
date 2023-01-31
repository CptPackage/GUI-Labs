
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LibraryApp.Pages
{
    public class EditBook : PageModel
    {
        private readonly ILogger<EditBook> _logger;

        public EditBook(ILogger<EditBook> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}