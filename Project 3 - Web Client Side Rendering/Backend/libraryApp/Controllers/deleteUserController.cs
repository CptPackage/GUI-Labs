using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libraryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deleteUserController : ControllerBase
    {

        private readonly ILogger<deleteUserController> _logger;

        public deleteUserController(ILogger<deleteUserController> logger)
        {
            _logger = logger;
        }

        public class DeleteUserPostRq
        {
            public string login { get; set; }
        }
        [HttpPost(Name = "PostDeleteUser")]
        public void Post(DeleteUserPostRq rq)
        {
            // dataHandler.get().printAllUsers();
            if (!ModelState.IsValid)
            {
                Console.WriteLine("got invalid request");
                Console.WriteLine(ModelState);
            }
            Console.WriteLine("got deleteUser post request");
            Console.WriteLine("login: " + rq.login );
            dataHandler.get().getUsers().Remove(dataHandler.get().getUser(rq.login));

        }
    }
}
