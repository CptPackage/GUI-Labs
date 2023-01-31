using LibraryApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index(string myBooks = "off", string avaliable = "off", string author = "", string title = "")
        {
            if(myBooks != "off" || avaliable != "off" || author != "" || title != "")// (Request.HasFormContentType && Request.Form != null && Request.Form.Count > 0)
            {
                if (title == null) title = "";
                else title = title.ToLower();
                if (author == null) author = "";
                else author = author.ToLower();

                List<Book> books = new List<Book>();
                List<Book> allBooks = dataHandler.get().getBooks();
                foreach (Book book in allBooks)
                {
                    //Console.WriteLine("asdf: " + book.author.Contains(author));
                    //Console.WriteLine("b");
                    if((myBooks == "off" || book.user == dataHandler.getUser()) && (avaliable == "off" || book.getStatus()=="avaliable") &&
                        book.author.ToLower().Contains(author) && book.title.ToLower().Contains(title) )
                    {
                        books.Add(book);
                    }
                }
                ViewBag.myBooks = myBooks == "on";
                ViewBag.avaliable = avaliable == "on";
                ViewBag.author = author;
                ViewBag.filterTitle = title;
                return View(books);
            }
            else
            {
                return View(dataHandler.get().getBooks());
            }
            
        }
        public IActionResult Book(int b)
        {
            if (b == 0)
            {
                return Redirect("/library");
            }
            ViewBag.b = b;
            return View();
        }
        public IActionResult EditBook(int b)
        {
            //Console.WriteLine("a");
            //Console.WriteLine("id: " + b + " author: " + author + " title: " + title + " date: " + date + " publisher: " + publisher + " user: " + user + " a: " + a);
            
            if (Request.HasFormContentType && Request.Form != null && Request.Form.Count > 0)
            {
                String a = HttpContext.Request.Form["a"].ToString();
                //Console.WriteLine("c");
                if (dataHandler.getUser() != "librarian")
                {
                    //Console.WriteLine("user isn't the librarian");
                    return Redirect("/library");
                }
                Book loc = dataHandler.get().getBook(b);
                if(a == "edit")
                {
                    string author = HttpContext.Request.Form["author"].ToString();
                    int date = Int32.Parse(HttpContext.Request.Form["date"].ToString());
                    string publisher = HttpContext.Request.Form["publisher"].ToString();
                    string title = HttpContext.Request.Form["title"].ToString();
                    string user = HttpContext.Request.Form["user"].ToString();
                    b = Int32.Parse(HttpContext.Request.Form["b"].ToString());
                    string status = HttpContext.Request.Form["status"].ToString();
                    //Console.WriteLine("d");
                    dataHandler.get().editBook(b, author, date, loc.leased, publisher, loc.reserved, title,user, status);
                    //dataHandler.get().printAllBooks();
                }

            }
            else if (b == 0)
            {
                //Console.WriteLine("b");
                return Redirect("/library");
            }
            //Console.WriteLine("e");
            ViewBag.b = b;

            return View();
        }
        public IActionResult ReserveBook(int b)
        {
            //Console.WriteLine("ReserveBook called b:"+b.ToString());
            dataHandler.get().changeBookStatus(b,"reserved", dataHandler.getUser());
            return Redirect("/library");
        }
     /*   public IActionResult LeaseBook(int b)
        {
            Console.WriteLine("LeaseBook called b:" + b.ToString());
            dataHandler.get().changeBookStatus(b, "leased", dataHandler.getUser());
            return Redirect("/library");
        }*/
        public IActionResult ReleaseBook(int b)
        {
            //Console.WriteLine("ReleaseBook called b:" + b.ToString());
            dataHandler.get().changeBookStatus(b, "avaliable", dataHandler.getUser());
            return Redirect("/library");
        }
    }
}
