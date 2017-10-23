using System;
using System.Collections.Generic;

namespace feedme
{
    class DateProposal
    {
        private static int number_of_dateproposals = 0; 
        public int Id = 0; 
        public string Title {get; set; }
        public int creater_id {get; set; }
        public List<int> interested_profiles = new List<int>();
        public int select_match_profile_id {get; set;}
        public Restaurant restaurant {get; set; }
        List<Tag> tags = new List<Tag>();
        
        public DateProposal(int id, string title)
        {
            number_of_dateproposals++;
            this.Id = number_of_dateproposals; 
            this.creater_id = id; 
            this.Title = title; 
            Console.WriteLine("Creating new DateProposal: " + title);
        }

        public void AddProfileIdToInterested(int profile_id)
        {
            interested_profiles.Add(profile_id); 
            // TODO: Push notificatin to creater
            Console.WriteLine(profile_id + " is interested in DateProposal with id: " + Id);
        }

        internal void ShowDateProposal()
        {
            Console.WriteLine(Id + ": Title: " + Title);
            Console.WriteLine("  Created by: " + creater_id);

        }

        public void AddTag(Tag tag)
        {
            tags.Add(tag);
        }

        public void SelectMatch(int profile_id)
        {
            select_match_profile_id = profile_id;
            Console.WriteLine("You have a match! with " + profile_id);
            // Push notification to match
            Console.WriteLine("Profile " + profile_id + " you have a match with " + creater_id);
        }
    }
}
