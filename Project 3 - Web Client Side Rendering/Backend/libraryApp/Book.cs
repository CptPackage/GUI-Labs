using System.Runtime.CompilerServices;

namespace libraryApp
{
    public struct Book
    {
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string publisher { get; set; }
        public int date { get; set; } // format: yyyy
        public string user { get; set; }
        public DateTime? reserved { get; set; } //format "yyyy-MM-dd"
        public DateTime? leased { get; set; } //format "yyyy-MM-dd"

        public Book(int id, string author, string title, int date, string publisher,  string user, DateTime? reserved, DateTime? leased)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.date = date;
            this.user = user;
            this.reserved = reserved;
            this.leased = leased;
            // TODO:
            // check if reservation is not outdated
        }
        public string toJson()
        {
            string ret = "";
            ret += "        \"author\": \"" + author + "\",";
            ret += "        \"date\": \"" + date + "\",";
            ret += "        \"id\": \"" + id + "\",";
            ret += "        \"leased\": \"" + leased + "\",";
            ret += "        \"publisher\": \"" + publisher + "\",";
            ret += "        \"reserved\": \"" + reserved + "\"";
            ret += "        \"title\": \"" + title + "\",";
            ret += "        \"user\": \"" + user + "\"";

            return ret;
        }
        public bool print()
        {
            Console.WriteLine("book id: " + id + "\n author: " + author + "\n title: " + title +
                "\n publisher: " + publisher + "\n date: " + date + "\n user: " + user +
                "\n reserved: " + reserved + "\n leased: " + leased);
            return true;
        }
        public void edit(string author, int date, DateTime? leased, string publisher, DateTime? reserved, string title, string user)
        {
            //Console.WriteLine("book.edit got:");
            //Console.WriteLine("author: "+author+" date: "+date.ToString()+" leased: "+leased.ToString()+" publisher: "+publisher+" reserved: "+reserved.ToString+" title: "+title+" user: "+user);
            this.author = author;
            this.date = date;
            this.leased = leased;
            this.publisher = publisher;
            this.reserved = reserved;
            this.title = title;
            this.user = user;

            //Console.WriteLine("book edited: ");
            //  this.print();
        }
        /*
        public void reserve(string user)
        {
            if(this.reserved == null)
            {
                Console.WriteLine("reserving book");
                this.reserved = DateTime.Now;
                this.leased = null;
                this.user = user;
                this.print();
            }
        }
        public void lease()
        {
            if(this.leased == null)
            {
                if (this.reserved == null)
                {
                    this.reserved = DateTime.Now;
                }
                this.leased = DateTime.Now;
            }
        }
        public void lease(string user)
        {
            this.lease();
            this.user = user;
        }
        public void release()
        {
            this.reserved = null;
            this.leased = null;
            this.user = "";
        }*/
        public string getStatus()
        {
            if (this.reserved == null)
            {
                this.leased = null;
                return ("avaliable");
            }
            else
            {
                if (this.leased == null)
                {
                    return ("reserved");
                }
                else
                {
                    return ("leased");
                }
            }
        }
    }




    /*
    public struct BookStrings
    {
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string publisher { get; set; }
        public int date { get; set; } // format: yyyy
        public string user { get; set; }
        public string reserved { get; set; } //format "yyyy-MM-dd"
        public string leased { get; set; } //format "yyyy-MM-dd"

        public Book returnBook()
        {
            Book b;
            
            if (leased != "")
            {
                
                if(reserved != "")
                {
                    DateTime leasedDate = DateTime.Parse(leased);
                    DateTime reservedDate = DateTime.Parse(reserved);
                    b = new Book(id, author, title, date, publisher, user, reservedDate, leasedDate);
                }
                else
                {
                    //this case is improper since a book that has a lease date has to have a reserve date
                    b = new Book(id, author, title, date, publisher, user, null, null);
                }
            }
            else
            {
                if(reserved != "")
                {
                    DateTime reservedDate = DateTime.Parse(reserved);
                    b = new Book(id, author, title, date, publisher, user, reservedDate, null);
                }
                else
                {
                    b = new Book(id, author, title, date, publisher, user, null, null);
                }
            }
            

            return b;
        }

    }*/
}
