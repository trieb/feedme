using System;

namespace feedme
{
    class User
    {
        private static int Id = 0; 
        public string Email { get; set; }
        public string Password {get; set; }
        
        public User(string email, string password)
        {
            Id++;  
            this.Email = email;
            this.Password = password; 
            Console.WriteLine("Creating User " + Id + ": " + this.Email + " " + this.Password);
        }
        
    }
}
