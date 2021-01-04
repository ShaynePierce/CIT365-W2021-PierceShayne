using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name? ");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi {person.name}! Where are you from? ");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
        }

        static void ChristmasCountdown(DateTime MyDateTime)
        {
            Console.WriteLine($"Today's date is: {MyDateTime:g}");
            int DaysUntilChristmas = ((TimeSpan) (new DateTime(MyDateTime.Year, 12, 25) - MyDateTime)).Days;
            Console.WriteLine($"There are {DaysUntilChristmas} days until Christmas!");

        }

        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();
            Console.WriteLine("Press any key to terminate...");
            Console.ReadKey();
        }

    }
}
