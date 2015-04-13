using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace determine_numbers
{
    class Program
    {
        static bool IsPositive(int number)
        {
            return number >= 0;
        }

        static bool IsDivided(int number)
        {
            return number%2 == 0 && number%3 == 0 && number%5 == 0 && number%6 == 0 && number%9 == 0;
        }

        static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return true;
            }

            for (int i = 2; i <= number; i++)
            {
                if (number%i == 0)
                {
                    if (number == i)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter number with :");
            int n = int.Parse(Console.ReadLine());

            if (IsPositive(n))
            {
               Console.WriteLine("Positive");  
            }
            else
            {
                Console.WriteLine("Negative");
            }

            if (IsPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

            if (IsDivided(n))
            {
                Console.WriteLine("Divided by 2, 5, 3, 6, 9");
            }
            else
            {
                Console.WriteLine("Not Divided by 2, 5, 3, 6, 9");
            }

            Console.ReadLine();
        }
    }
}
