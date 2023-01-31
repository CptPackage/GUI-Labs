using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libraryApp.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class checkUserController : ControllerBase
    {

        private readonly ILogger<checkUserController> _logger;

        public checkUserController(ILogger<checkUserController> logger)
        {
            _logger = logger;
        }

        public class checkUserPostRq
        {
            public string login { get; set; }
            public string pwd { get; set; }
        }
        [HttpPost(Name = "PostCheckUser")]
        public bool Post(checkUserPostRq rq)
        {
            // dataHandler.get().printAllUsers();
            if (!ModelState.IsValid)
            {
                Console.WriteLine("got invalid request");
                Console.WriteLine(ModelState);
            }
            Console.WriteLine("got checkUser post request");
            Console.WriteLine("login: "+rq.login+" password: "+rq.pwd);
            if(dataHandler.get().UserExists(rq.login))
            {
                if (dataHandler.get().getUser(rq.login).checkPassword(rq.pwd))
                {
                    Console.WriteLine("user: " + rq.login + " exists");
                    return true;
                }
            }
            
            
            Console.WriteLine("wrong data");
            return false;
        }
    }
}
