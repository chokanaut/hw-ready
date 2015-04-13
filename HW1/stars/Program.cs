using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stars
{
    class Program
    {
       
        static void triangle(int n)
        {
            int indent = n / 2 + 1;
            string s = "*".PadLeft(indent);
            for (int k = 0; k < indent; k++)
            {
                Console.WriteLine(s);
                s = s.Substring(1) + "**";
            }
            Console.ReadLine();

        } 

        
        {
        }
    }
}
