
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LibraryApp.Pages
{
    public class Book : PageModel
    {
        private readonly ILogger<Book> _logger;

        public Book(ILogger<Book> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}