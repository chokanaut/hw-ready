using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int result = 1;
            do
            {
                result = result*i;
                i++;
            } while (i<=n);
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
