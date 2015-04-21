using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static2
{
    static class ArrayExtensions
    {
        public static void Sort(this int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 2;
            arr[1] = 1;
            arr[2] = 0;
            arr[3] = 9;
            arr[4] = 3;

            ArrayExtensions.Sort(arr);

            arr.Sort();
        }
    }
}

