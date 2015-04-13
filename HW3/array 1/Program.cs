using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 23;
            int[] numbers = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(0,100);
                Console.WriteLine(numbers[i]);
            }

            int max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Max number is: " + max);

            int min = numbers[0];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Min number is: " + min);

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum is: " + sum);

            double average = (double)sum / (double)n;
            Console.WriteLine("Average is: " + average);

            for (int i = 0; i < n; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    Console.WriteLine("Even: " + numbers[i]);
                }
            }


            Console.ReadLine();

        }
    }
}
