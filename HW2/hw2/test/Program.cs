using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            z = x++ & y * 5;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
