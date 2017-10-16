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

        public void CreateDateProposal(string title)
        {
            DateProposal new_date = new DateProposal(title);
            // Get user input and add to DateProposal-object
        }

    }
}
