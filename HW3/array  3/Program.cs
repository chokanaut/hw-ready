using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array__3
{
    class Program
    {
        static int[] AddElement(int[] arr, int value)
        {
            int[] res = new int[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }

            res[arr.Length] = value;

            return res;
        }

        static void Main(string[] args)
        {
            int n = 5;
            int[] numbers = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(0, 100);
                Console.WriteLine(numbers[i]);
            }

            int[] res = AddElement(numbers, 5);
            Console.WriteLine("Array with new element:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();


        }
    }
}
