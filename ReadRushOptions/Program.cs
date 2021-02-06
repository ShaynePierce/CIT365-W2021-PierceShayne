using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReadRushOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Console.WriteLine(RushOptions.RushPrices[0,0]);
            RushOptions ru = new RushOptions();
            Console.WriteLine("Count: " + ru.count.ToString());
            Console.ReadKey();
        }
    }
}
