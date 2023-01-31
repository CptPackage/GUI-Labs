using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Numerics;


namespace LibraryApp.Models
{
    
    class container<T> where T : struct{
        public List<T> _data;
        public string _path;

        public ref List<T> getData(){
            return ref _data;
        }
        public container(string filePath){
            this._path = filePath;
            this._data = new List<T>();
            
            
        }
        ~container() {
        }
    }
    public class data
    {
        
        private container<User> users;
        private container<Book> books;
        public void addUser(string userId, string password){
            users.getData().Add(new User(userId,  password));
            save();
        }
       
        public void printAllUsers(){
            if(users._data != null){
                for(int i = 0; i < users._data.Count; i++){
                    users._data[i].print();
                }
            }
        }
        public User getUser(string login){
           // Console.WriteLine("looking for: "+login);
            if(users._data != null){
                for(int i = 0; i<users._data.Count;i++){
                    if(users._data[i].user == login){
                        Console.WriteLine("User found");
                        return users._data[i];
                    }
                }
            }
            return new User("","");
        }
        public Book getBook(int id)
        {
            if (books._data != null)
            {
                for (int i = 0; i < books._data.Count; i++)
                {
                    if (books._data[i].id == id)
                    {
                        Console.WriteLine("Book Found");
                        return books._data[i];
                    }
                }
            }
            throw new InvalidOperationException("This book doesn't exist");
            // return new Book(-1, "", "", "", 0, "", new DateOnly(), new DateOnly()) ;
        }
        
        public bool editBook(int id, string author, int date, DateTime? leased, string publisher, DateTime? reserved, string title, string user, string status)
        {
         //   Console.WriteLine("EditBook got:");
         //   Console.WriteLine("author: " + author + " date: " + date.ToString() + " leased: " + leased.ToString() + " publisher: " + publisher + " reserved: " + reserved.ToString + " title: " + title + " user: " + user);
            if (books._data != null)
            {
                for (int i = 0; i < books._data.Count; i++)
                {
                    if (books._data[i].id == id)
                    {
                    //    Console.WriteLine("Book Found");
                    //    books._data[i].print();
                    //    books._data[i].edit(author, date, leased, publisher, reserved, title, user);
                     //   books._data[i].print();
                     //   books.getData()[i].print();
                        // books.getData()[i].edit(author, date, leased, publisher, reserved, title, user);
                        DateTime? locRes = books.getData()[i].reserved;
                        DateTime? locLeas = books.getData()[i].leased;
                        books.getData()[i] = new Book(id, author, title, publisher, date, user, locRes, locLeas);
                        //    books.getData()[i].print();
                        if (status == "reserved")
                        {
                            Console.WriteLine("new book status: reserved");
                            Book loc = books._data[i];
                            books._data[i] = new Book(id, author, title, publisher, date, user, DateTime.Now.Date, null);
                            //  books._data[i].reserve(user);
                        }
                        else if (status == "leased")
                        {
                            Console.WriteLine("new book status: leased");
                            Book loc = books._data[i];
                            if (loc.getStatus() == "avaliable")
                            {
                                books._data[i] = new Book(id, author, title, publisher, date, user, DateTime.Now.Date, DateTime.Now.Date);
                            }
                            else
                            {
                                books._data[i] = new Book(id, author, title, publisher, date, user, loc.reserved, DateTime.Now.Date);
                            }
                            // books._data[i].lease(user);
                        }
                        else
                        {
                            Console.WriteLine("new book status: avaliable");
                            Book loc = books._data[i];
                            books._data[i] = new Book(id, author, title, publisher, date, "", null, null);
                            //books._data[i].release();
                        }
                        save();
                        return true;
                    }
                }
            }
            return false;
        }
        public bool changeBookStatus(int id, string newStatus, string user)
        {
            if (books._data != null)
            {
                for (int i = 0; i < books._data.Count; i++)
                {
                    if (books._data[i].id == id)
                    {
                        Console.WriteLine("Book Found");
                        if(newStatus == "reserved")
                        {
                            Console.WriteLine("got to book.reserve call");
                            Book loc = books._data[i];
                            books._data[i] = new Book(id, loc.author, loc.title, loc.publisher, loc.date, user, DateTime.Now.Date, null);
                          //  books._data[i].reserve(user);
                        }
                        else if(newStatus == "leased")
                        {
                            Console.WriteLine("got to book.lease call");
                            Book loc = books._data[i];
                            if (loc.getStatus() == "avaliable")
                            {
                                books._data[i] = new Book(id, loc.author, loc.title, loc.publisher, loc.date, user, DateTime.Now.Date, DateTime.Now.Date);
                            }
                            else
                            {
                                books._data[i] = new Book(id, loc.author, loc.title, loc.publisher, loc.date, user, loc.reserved, DateTime.Now.Date);
                            }
                           // books._data[i].lease(user);
                        }
                        else
                        {
                            Console.WriteLine("got to book.release call");
                            Book loc = books._data[i];
                            books._data[i] = new Book(id, loc.author, loc.title, loc.publisher, loc.date, "", null, null);
                            //books._data[i].release();
                        }
                        save();
                        return true;
                    }
                }
            }
            return false;

        }

        public bool UserExists(string login){
            // Console.WriteLine("looking for: "+login);
            if(users._data != null){
                for(int i = 0; i<users._data.Count;i++){
                    if(users._data[i].user == login){
                        // Console.WriteLine("User found");
                        return true;
                    }
                }
            }
            return false;

        }
        public bool BookExists(int id){
            // Console.WriteLine("looking for: "+id);
            if(books._data != null){
                for(int i = 0; i<books._data.Count;i++){
                    if(books._data[i].id == id){
                        // Console.WriteLine("Book found");
                        return true;
                    }
                }
            }
            return false;

        }
        public List<User> getUsers(){
            return users.getData();
        }
        public List<Book> getBooks(){
            return books.getData();
        }
        public void printAllBooks(){
            if(books._data != null){
                for( int i = 0; i < books._data.Count; i++){
                    books._data[i].print();
                }
            }
            
        }
        public data(string folderPath){
            this.users = new container<User>(folderPath+"users.json");
            this.books = new container<Book>(folderPath+"books.json");
            
            string jsonString = File.ReadAllText(users._path);
            Console.Write(jsonString);
            Console.WriteLine("file length: "+jsonString.Length);
            if(jsonString.Length > 10){
                var options = new JsonSerializerOptions{
                    AllowTrailingCommas = true,
                };
                users._data = JsonSerializer.Deserialize<List<User>>(jsonString,options)!;
            }
            else{
                users._data = new List<User>();
            }

            
            jsonString = File.ReadAllText(books._path);
            Console.Write(jsonString);
            Console.WriteLine("file length: "+jsonString.Length);
            if(jsonString.Length > 10){
                var options = new JsonSerializerOptions{
                    AllowTrailingCommas = true,
                };
                books._data = JsonSerializer.Deserialize<List<Book>>(jsonString, options)!;
                /*
                //JsonSerializer.Deserialize<List<Book>>(jsonString, options).ForEach(action: delegate (Book item) { item.print(); });
                List<BookStrings> bookStrings;
                bookStrings = JsonSerializer.Deserialize<List<BookStrings>>(jsonString,options)!;
                bookStrings.ForEach(delegate(BookStrings strings)
                {
                    Book newBook = new Book(-1, "", "", "", 0, "", new DateTime(), new DateTime());
                    if (strings.leased != "")
                    {

                        if (strings.reserved != "")
                        {
                            DateTime leasedDate = DateTime.Parse(strings.leased);
                            DateTime reservedDate = DateTime.Parse(strings.reserved);
                            newBook = new Book(strings.id, strings.author, strings.title, strings.publisher, strings.date, strings.user, reservedDate, reservedDate);
                        }
                        else
                        {
                            //this case is improper since a book that has a lease date has to have a reserve date
                            newBook = new Book(strings.id, strings.author, strings.title, strings.publisher, strings.date, strings.user, null, null);
                        }
                    }
                    else
                    {
                        if (strings.reserved != "")
                        {
                            DateTime reservedDate = DateTime.Parse(strings.reserved);
                            newBook = new Book(strings.id, strings.author, strings.title, strings.publisher, strings.date, strings.user, reservedDate, null);
                        }
                        else
                        {
                            newBook = new Book(strings.id, strings.author, strings.title, strings.publisher, strings.date, strings.user, null, null);
                        }
                    }
                    books._data.Add(newBook);
                });*/
            }
            else{
                books._data = new List<Book>();
            }

            printAllUsers();
            printAllBooks();
        }

        public void save(){

            //Console.WriteLine("jsonString:\n"+ jsonString);
            var options = new JsonSerializerOptions { WriteIndented = true };

            using FileStream userStream1 = File.Create(users._path);
            JsonSerializer.SerializeAsync(userStream1, users._data, options);
            userStream1.DisposeAsync();

            using FileStream bookStream1 = File.Create(books._path);
            JsonSerializer.SerializeAsync(bookStream1, books._data, options);
            bookStream1.DisposeAsync();

            /*string booksJson = "[";
            foreach(Book book in books._data){
                booksJson +="{";
                booksJson += book.toJson();
                booksJson += "},";
            }
            booksJson.Remove(booksJson.Length-1);
            booksJson += "]";
            //Console.WriteLine("all books in json"+booksJson);

            //using FileStream createStream = File.Create(books._path);
            File.WriteAllTextAsync(books._path, booksJson);
            // JsonSerializer.SerializeAsync(createStream, books._data);
            // createStream.DisposeAsync();
            Console.WriteLine("save finished");*/
        }
        ~data(){
            save();
        }

    }
    public class dataHandler
    {
        static string currUser = "";
        static data _data;
        public static ref data get(){
            return ref _data;
        }
        public static string getUser(){
            return currUser;
        }
        public static void setUser(string usr){
            Console.WriteLine("New current user: "+usr);
            currUser = usr;
        }
        public dataHandler(string folderPath){
            _data = new data(folderPath);
        }
        
        
    }
}