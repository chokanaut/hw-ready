﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 15;
            x += y >> (x++*z);
            Console.WriteLine(x);
            x = 5;
            y = 10;
            z = 15;
            z = ++x & y*5;
            Console.WriteLine(z);
            x = 5;
            y = 10;
            z = 15;
            y /= x + 5 | z;
            Console.WriteLine(y);
            x = 5;
            y = 10;
            z = 15;
            z = x++ & y*5;
            Console.WriteLine(z);
            x = 5;
            y = 10;
            z = 15;
            x = y << x++ ^ z;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
