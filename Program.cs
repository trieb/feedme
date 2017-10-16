using System;
using System.Collections.Generic;

namespace feedme
{
    class Program
    {
        /*    
        Since this is a toy example we will not use a real database, 
        instead we will just keep everything in arrays in the main program just to keep it simple. 
        The fokus is on the use of classes. 
        
        * User            users[]
        * Profile         profiles[]
        * RestaurangOwner restaurantowners[]
        * DateProposal    dateproposals[]
        * Match           matches[]
        * Chat            chats[]
        * Restaurant      restaurants[]
         */
        
        
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>();

            Console.WriteLine("Hello World!");

            Profile p1 = new Profile("donald@gmail.com", "secret");
            profiles.Add(p1);
            Profile p2 = new Profile("hans@boll.se", "hemligt");
            profiles.Add(p2);
            Profile p3 = new Profile("johanna@gmail.com", "secret2");
            profiles.Add(p3);
            Profile p4 = new Profile("erika@gmail.com", "secret4");
            profiles.Add(p4);
            
            
        }
    }
}
