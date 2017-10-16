using System;
using System.Collections.Generic;

namespace feedme
{
    class DateProposal
    {
        private static int Id = 0; 
        public string Title {get; set; }
        public int creater_id {get; set; }
        List<int> interested_profiles = new List<int>();
        public Restaurant restaurant {get; set; }
        List<Tag> tags = new List<Tag>();
        
        public DateProposal(string title)
        {
            Id++; 
            this.Title = title; 
            Console.WriteLine("Creating new DateProposal: " + title);
        }

        public void ShowInterest(int profile_id)
        {
            interested_profiles.Add(profile_id);           
            Console.WriteLine(profile_id + " is interested in this proposal!");
            // TODO: Push notificatin to creater
        }
        
        public void AddTag(Tag tag)
        {
            tags.Add(tag);
        }

        public void SelectMatch(int profile_id)
        {
            Console.WriteLine("You have a match! with " + profile_id);
        }
    }
}
