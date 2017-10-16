using System;

namespace feedme
{
    class Profile : User
    {
        public string Fname  {set; get; }
        public string Lname  {set; get; }
        public string Bio  {set; get; }
        public int Age  {set; get; }
        public string Gender {set; get; }

        public Profile(string email, string password) : base(email, password)
        {
            Console.WriteLine("Creating new Profile");
        }
    }
}
