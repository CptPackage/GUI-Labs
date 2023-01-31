using Microsoft.AspNetCore.Mvc;

using libraryApp;
using System.Runtime.InteropServices;

namespace libraryApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class allBooksController : ControllerBase
    {

        private readonly ILogger<allBooksController> _logger;

        public allBooksController(ILogger<allBooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public List<Book> Get()
        {
            // dataHandler.get().printAllUsers();
            Console.WriteLine("got book request");
            return dataHandler.get().getBooks();
        }
    }
}