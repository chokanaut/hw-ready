using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter money:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exchange with ','"); 
            double e = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(m*e);
            Console.ReadLine();
        }
        
      
    }
     
}
