using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Objects
        Address lectureAddress = new Address("30 Jesup Road", "Westport", "Massachusetts", "USA");
        Lecture lecture = new Lecture("The Art of Storytelling: Crafting Compelling Narratives for Impactful Communication", "Embark on a captivating journey into the world of storytelling with Professor Jonathan Harper, a masterful storyteller and communication expert. In this dynamic and interactive lecture, Professor Harper will unveil the secrets behind crafting narratives that captivate, inspire, and evoke emotion.", "March 15, 2024", "10:00 AM - 12:00 PM EST", lectureAddress, "Professor Jonathan Harper", 120);
        Address receptionAddress = new Address("221 Enchanted Way", "Springland", "Florida", "USA");
        Reception reception = new Reception("Garden Gala: A Night of Enchantment", "Step into a world of elegance and enchantment at the Garden Gala hosted by Rosewood Manor Gardens. This spectacular event invites guests to indulge in an evening of refined dining, lively entertainment, and magical ambiance amidst the lush greenery and blooming flowers of the manor's exquisite gardens. RSVP to the included email.", "May 25, 2024", "8:00 PM - 10:00 PM EST", receptionAddress, "enchantedgala2024@gmail.com");
        Address outdoorAddress = new Address("467 Orchard Way", "Columbia", "South Carolina", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Charleston Orchard Opening Party", "Come celebrate the opening of the stores at Charleston Orchard with an evening of drinks, music, and dance. Vendors and local businesspeople will be there to enjoy the night together just before our new shopping plaza opens on Monday. Event will take place in the namesake orchard just past the East parking area. Complimentary champagne and snacks will be served and there will be an open bar. In the event of inclement weather, the event will be moved inside the plaza office.", "April 27, 2024", "7:00 PM - 10:00 PM EST", outdoorAddress, "Bright and sunny with a small chance of showers in the early evening.");

        // Displaying marketing messages
        Console.WriteLine("-----------------Lecture - Standard Details---------------------------------------------");
        Console.WriteLine(lecture.ShowStandardDetails());
        Console.WriteLine("-----------------Lecture - Full Details-------------------------------------------------");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("-----------------Lecture - Short Description--------------------------------------------");
        Console.WriteLine(lecture.ShowShortDescription());

        Console.WriteLine("-----------------Reception - Standard Details-------------------------------------------");
        Console.WriteLine(reception.ShowStandardDetails());
        Console.WriteLine("-----------------Reception - Full Details-----------------------------------------------");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("-----------------Reception - Short Description------------------------------------------");
        Console.WriteLine(reception.ShowShortDescription());

        Console.WriteLine("-----------------Outdoor Gathering - Standard Details-----------------------------------");
        Console.WriteLine(outdoor.ShowStandardDetails());
        Console.WriteLine("-----------------Outdoor Gathering - Full Details---------------------------------------");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("-----------------Outdoor Gathering - Short Description----------------------------------");
        Console.WriteLine(outdoor.ShowShortDescription());
    }
}