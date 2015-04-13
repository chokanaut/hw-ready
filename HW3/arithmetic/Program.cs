using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        static double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        static double Mul(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        static double Div(double operand1, double operand2)
        {
            return operand1 / operand2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A with','");
            double operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B with','");
            double operand2 = double.Parse(Console.ReadLine());
           
            Console.Write("Enter operation:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(Add(operand1, operand2));
                    break;
                case "-":
                    Console.WriteLine(Sub(operand1, operand2));
                    break;
                case "*":
                    Console.WriteLine(Mul(operand1 , operand2));
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Can't divide by 0");
                    }
                    else
                    {
                        Console.WriteLine(Div(operand1 , operand2));
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}
