using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    static class GlazerApp
    {
        public static void RunExample()
        {   
            //code copied from C# Programming Book by Rob Miles
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("\nWe will calculate the lumber and glass needed for a window. ");
            Console.WriteLine("This was adopted from code found in Rob Mile's \"C# Programming Yellow Book\". ");
            Console.Write("Please enter the width in meters: "); //this prompt added, assume all input measurements are in meters
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please enter the height in meters: "); //this prompt added, assume all input measurements are in meters
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet. ");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters. \n");
        }
    }
}
