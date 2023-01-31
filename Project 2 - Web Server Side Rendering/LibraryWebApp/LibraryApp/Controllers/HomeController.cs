using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using LibraryApp.Models;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: HomeController
        public ActionResult Index() => Redirect("/library");

        // GET: HomeController/privacy
        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Login(string login, string password)
        {
            Console.WriteLine("login: " + login + " password: " + password);
            if (login == null & password == null)
            {
                return View();
            }

            if (dataHandler.get().getUser(login).checkPassword(password))
            {
                dataHandler.setUser(login);
                return Redirect("/library");
            }
            ViewBag.Message = "errors";
            return View();
        }

        public ActionResult Logout()
        {
            dataHandler.setUser("");
            return Redirect("/home/login");
        }

        public ActionResult SignUp(string login, string password)
        {
            if(login != null & password != null)
            {
                if (dataHandler.get().getUser(login).returnLogin() == "")
                {
                    dataHandler.get().getUsers().Add(new Models.User(login, password));
                    dataHandler.get().save();
                    return Redirect("/home/login");
                }
                else
                {
                    ViewBag.message = "userExists";
                }
            }
            else
            {
                return View();
            }
            ViewBag.Message = "errors";
            return View();

        }
    }
}
