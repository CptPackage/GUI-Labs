using Microsoft.AspNetCore.Mvc;

using libraryApp;
using System.Runtime.InteropServices;

namespace libraryApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class changeBookStateController : ControllerBase
    {

        private readonly ILogger<changeBookStateController> _logger;

        public changeBookStateController(ILogger<changeBookStateController> logger)
        {
            _logger = logger;
        }
        public class ChangeBookStatePostRq
        {
            public string activeUser { get; set; }
            public string newUser { get; set; }
            public int bookId { get; set; }
            public string newState { get; set; }
        }
        [HttpPost(Name = "PostChangeBookState")]
        public bool Post(ChangeBookStatePostRq rq)
        {
            // dataHandler.get().printAllUsers();
            Console.WriteLine("got change book state post request");
            
            return dataHandler.get().changeBookStatus(rq.bookId, rq.newState, rq.newUser);

        }

    }
}