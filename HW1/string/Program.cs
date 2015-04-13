using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\n моя строка 1";
            string b = "\t моя строка 2";
            string c = "\a моя строка 3";
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.ReadLine();
        }
    }
}
