using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libraryApp.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class addUserController : ControllerBase
    {

        private readonly ILogger<addUserController> _logger;

        public addUserController(ILogger<addUserController> logger)
        {
            _logger = logger;
        }

        public class AddUserPostRq
        {
            public string login { get; set; }
            public string pwd { get; set; }
        }
        [HttpPost(Name = "PostAddUser")]
        public bool Post(AddUserPostRq rq)
        {
            // dataHandler.get().printAllUsers();
            if (!ModelState.IsValid)
            {
                Console.WriteLine("got invalid request");
                Console.WriteLine(ModelState);
            }
            Console.WriteLine("got addUser post request");
            Console.WriteLine("login: "+rq.login+" password: "+rq.pwd);
            if(!dataHandler.get().UserExists(rq.login))
            {
                Console.WriteLine("adding user: " + rq.login);
                dataHandler.get().addUser(rq.login, rq.pwd);
                Console.WriteLine("User added!");
                return true;
            }
            
            Console.WriteLine("user already exists :(");
            return false;
        }
    }
}
