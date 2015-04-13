using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nuber A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int b = int.Parse(Console.ReadLine());

            int i = a+1;
            int sum = 0;

            if (a < b)
            {
                while (i < b)
                { 
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("Odd " + i);
                    }
                    sum = sum + i;
                    i++;
                }
            }
            else
            {
               Console.WriteLine("Wrong input"); 
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

        }
    }
}
