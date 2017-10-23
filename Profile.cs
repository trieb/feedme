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

        public void CreateDateProposal(Data data, string title)
        {
            DateProposal new_date = new DateProposal(Id, title);
            data.dateProposals.Add(new_date);
            // Get user input and add to DateProposal-object
        }

        public void ListDateProposals(Data data)
        {
            foreach(var item in data.dateProposals) {
                item.ShowDateProposal();
            }
        }

        public void ShowInterestForDateProposal(Data data, int date_id)
        {
            if(date_id <= data.dateProposals.Count){
                data.dateProposals[date_id-1].AddProfileIdToInterested(Id);
            }
            else {
                Console.WriteLine("Data id " + date_id + " is larger than " + data.dateProposals.Count);
            }
            
        }

        internal void ShowDateSuggestions(Data data)
        {
            foreach(var item in data.dateProposals)
            {
                if(item.creater_id == Id){
                    if(item.interested_profiles.Count > 0){
                        Console.WriteLine("Choose one:");
                        foreach(var profile_id in item.interested_profiles){
                            Console.WriteLine("  Profile: " + profile_id);
                        }
                    }
                }
            }
        }

        internal void SelectProfileToMatch(Data data, int profile_id)
        {
            foreach(var item in data.dateProposals)
            {
                if(item.creater_id == Id){
                    item.SelectMatch(profile_id);
                }
            }
        }
    }
}
