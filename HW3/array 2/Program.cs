using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2
{
    class Program
    {

        static int[] MyReverse(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result[arr.Length - i - 1] = arr[i];
            }

            return result;
            
        }

        static int[] SubArray(int[] arr, int index, int count)
        {
            int [] sub = new int[count];

            for (int i = index; i < index + count; i++)
            {
                if (i < arr.Length)
                {
                    sub[i - index] = arr[i];
                }
                else
                {
                    sub[i - index] = 1;
                }
            }

            return sub;
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

            Console.WriteLine("Reversed");
            int[] res = MyReverse(numbers);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.WriteLine("Sub");

            int[] sub = SubArray(numbers, 2, 4);

            for (int i = 0; i < sub.Length; i++)
            {
                Console.WriteLine(sub[i]);
            }

            Console.ReadLine();
        }
    }
}
