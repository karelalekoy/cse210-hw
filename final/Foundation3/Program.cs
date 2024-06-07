using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // General address to be used by all events
        Address address = new Address("789 Palm Street", "Los Angeles", "CA", "USA");

        // Creating each event to then be displayed later on
        Lecture lecture = new Lecture("How to tie a tie", "Learning how to make the 3 basics tie knots", "June 5th, 2024", "5:45 PM", address, "Johnny A. Public", 200);
        Reception reception = new Reception("Francis & Maria's 50th Anniversary", "Come celebrate 50 years of marriage for Francis and Maria. Gifts are welcome, but not necessary", "Dicember 17th, 2024", "6:20 PM", address, "Fran@email.com");
        OutdoorGathering outdoor = new OutdoorGathering("Pool Party", "pool party will be in Derek's house. Please bring your own towel, bring a desert!.", "June 1th, 2024", "10:30 AM", address, "Sunny");

        // Displaying the details for each event
        Console.WriteLine("Event 1: Lecture");
        Console.WriteLine("Standard: \n" + lecture.GetStandardDetails());
        Console.WriteLine("Full: \n" + lecture.GetFullDetails());
        Console.WriteLine("Short: \n" + lecture.GetShortDescription());

        Console.WriteLine("Event 2: Reception");
        Console.WriteLine("Standard: \n" + reception.GetStandardDetails());
        Console.WriteLine("Full: \n" + reception.GetFullDetails());
        Console.WriteLine("Short: \n" + reception.GetShortDescription());

        Console.WriteLine("Event 3: Outdoor");
        Console.WriteLine("Standard: \n" + outdoor.GetStandardDetails());
        Console.WriteLine("Full: \n" + outdoor.GetFullDetails());
        Console.WriteLine("Short: \n" + outdoor.GetShortDescription());
    }
}