using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("not even");
            }
            Console.ReadLine();
        }
        }
    }

