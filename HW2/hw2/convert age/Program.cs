using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_age
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter year:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter salary:");
            double s = Double.Parse(Console.ReadLine());
           
                if (y > 0 && y < 5)
                {
                    Console.WriteLine(s*1.1);
                }
                else if (y >= 5 && y < 10)
                {
                    Console.WriteLine(s*1.15);
                }
                else if (y >= 10 && y < 15)
                {
                    Console.WriteLine(s*1.25);

                }
                else if (y >= 15 && y < 20)
                {
                    Console.WriteLine(s*1.35);
                }
                
                else if ( y>= 20 && y < 25)
                {
                    Console.WriteLine(s*1.45);
                }
                 else if (y >= 25 && y <= 50)
                 {
                     Console.WriteLine(s*1.5);
                 }
                 else
                 {
                     Console.WriteLine("Error: Out of range");
                 }

                
            
            Console.ReadLine();
        }
    }
}
