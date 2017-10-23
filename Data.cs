using System;
using System.Collections.Generic;

namespace feedme
{
    class Data
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

        public List<Profile> profiles = new List<Profile>();
        public List<DateProposal> dateProposals = new List<DateProposal>();
        public List<Match> matches = new List<Match>();

        public Data()
        {
            
        }
        
    }
}
