using System;

namespace feedme
{
    class User
    {
        private static int number_of_users = 0; 
        public int Id { get; }
        public string Email { get; set; }
        public string Password {get; set; }
        
        public User(string email, string password)
        {
            number_of_users++;
            this.Id = number_of_users;
            this.Email = email;
            this.Password = password; 
            Console.WriteLine("Creating User " + Id + ": " + this.Email + " " + this.Password);
        }
        
    }
}
