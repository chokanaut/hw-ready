using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 100)
            {
                if (number >= 0 && number <= 14)
                {
                    Console.WriteLine("[0-14]");
                }
                else if (number >= 15 && number <= 35)
                {
                    Console.WriteLine("[15-35]");
                }
                else if (number >= 36 && number <= 50)
                {
                    Console.WriteLine("[36-50]");

                }
                else if (number >= 51 && number <= 100)
                    Console.WriteLine("[51-100]");

            }
            else
            {
                Console.WriteLine("Don't include in the range");
            }
            Console.ReadLine();
        }
    }
}
