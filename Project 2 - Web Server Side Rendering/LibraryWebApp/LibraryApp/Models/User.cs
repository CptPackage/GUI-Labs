namespace LibraryApp.Models
{
    public struct User
    {
        public string user { get; set; }
        public string pwd { get; set; }
        public User(string log, string pwd)
        {
            user = log;
            this.pwd = pwd;
        }
        public bool checkPassword( string pwd)
        {
            return this.pwd == pwd;
        }
        public string toJson()
        {
            return "        \"user\":\"" + user + "\",\n       \"pwd\":\"" + pwd + "\"\n";
        }
        public bool isLibrarian()
        {
            return user == "librariabn";
        }
        public void print()
        {
            Console.WriteLine("user: " + this.user + " pwd: " + this.pwd);
        }
        public string returnLogin()
        {
            return user;
        }
    }
}
