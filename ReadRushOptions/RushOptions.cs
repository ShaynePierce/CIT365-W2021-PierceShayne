using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadRushOptions
{
    class RushOptions
    {
        public static readonly double[,] RushPrices = new double[3,3];

        public int count;

        public RushOptions()
        {
            count = 123;
        }

        static RushOptions()
        {
            string[] prices = { "" };

            try
            {
                prices = System.IO.File.ReadAllLines(@"rushOrderPrices.txt");
            }
            catch (Exception)
            {
                
            }
            
            if (prices.Length == 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        RushOptions.RushPrices[i,j] = double.Parse(prices[i * 3 + j]);
                        Console.WriteLine(RushOptions.RushPrices[i,j]);
                    }
                }
            }
        }
    }
}
