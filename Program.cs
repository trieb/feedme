using System;


namespace feedme
{
    class Program
    {
        static void Main(string[] args)
        {
            Data dataObject = new Data();

            Console.WriteLine("Hello World!");

            // Create profiles
            Profile p1 = new Profile("donald@gmail.com", "secret");
            dataObject.profiles.Add(p1);
            Profile p2 = new Profile("hans@boll.se", "hemligt");
            dataObject.profiles.Add(p2);
            Profile p3 = new Profile("johanna@gmail.com", "secret2");
            dataObject.profiles.Add(p3);
            Profile p4 = new Profile("erika@gmail.com", "secret4");
            dataObject.profiles.Add(p4);

            // Create DatePropsal
            p1.CreateDateProposal(dataObject, "Romantic dinner");
            p2.CreateDateProposal(dataObject, "Budget dinner for two");

            // List all DateProposals
            p3.ListDateProposals(dataObject);

            // Show intereset for DateProposal 1
            p3.ShowInterestForDateProposal(dataObject, 1);
            p4.ShowInterestForDateProposal(dataObject, 1);
            p4.ShowInterestForDateProposal(dataObject, 2);

            // Show list of profile interesed in DateProposal
            p1.ShowDateSuggestions(dataObject);
            p1.SelectProfileToMatch(dataObject, 3);

        }
    }
}
