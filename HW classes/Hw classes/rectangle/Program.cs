using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return this.side1*this.side2;
        }

        public double PerimeterCalculator()
        {
            return (this.side1 + this.side2)*2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.WriteLine("Enter side1,side2");
            side1 = double.Parse(Console.ReadLine());
            side2 = double.Parse(Console.ReadLine());
            var rec1 = new Rectangle(side1,side2);

            Console.WriteLine("result area:"+rec1.Area);
            Console.WriteLine("result perimetrer:" + rec1.Perimeter);



            Console.ReadLine();


        }

    }
}
