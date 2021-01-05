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
            //get the user's name and location
            Person person = new Person();
            Console.Write("What is your name? ");
            person.name = Console.ReadLine();
            Console.Write($"Hi {person.name}! Where are you from? ");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. ");
            Console.Write("Press any key to continue... \n");
            Console.ReadKey();
        }

        static void ChristmasCountdown(DateTime myDateTime)
        {
            //show the date and calculate the number of days to Christmas of the same year
            Console.WriteLine($"Today's date is: {myDateTime:d}");
            int daysUntilChristmas = ((TimeSpan) (new DateTime(myDateTime.Year, 12, 25) - myDateTime)).Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas! ");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }

        static void Main()
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();

            //promt the user before exiting the program
            Console.WriteLine("\nPress any key to end program...");
            Console.ReadKey();
        }
    }
}
