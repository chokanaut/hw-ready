using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
   public class Vehicle
    {
        public double x;
        public double y;
        public double price;
        public double years;
        public double speed;

       public Vehicle()
       {
          
       }

    }

    public class Plane : Vehicle
    {
        public double height;
        public double passengers;

        public Plane() :
            base()
        {

        }
    }

    public class Car : Vehicle
    {
        public Car() :
            base()
        {

        }
    }

    public class Ship : Vehicle
    {
        public double passengers ;
        public string port;

        public Ship() :
            base()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var plane = new Plane()
            {
                x = 10,
                y = 20,
                height = 1000,
                passengers = 120,
                price = 100000,
                speed = 700,
                years = 1989
            };

            var ship = new Ship()
            {
                x = 100,
                y = 200,
                passengers = 5000,
                port = "Odessa",
                price = 1000000,
                speed = 40,
                years = 1990
            };

            var car = new Car()
            {
                x = 400,
                y = 500,
                price = 10000,
                speed = 180,
                years = 2013
            };

            Console.WriteLine("Plane spec:");
            Console.WriteLine("Coordinates: x = " + plane.x + "y = "+ plane.y);
            Console.WriteLine("Price:" + plane.price);
            Console.WriteLine("Speed:"+ plane.speed);
            Console.WriteLine("Passengers:"+plane.passengers);
            Console.WriteLine("Height:"+plane.height);

            Console.WriteLine("Plane spec:");
            Console.WriteLine("Coordinates: x = " + ship.x + "y = "+ ship.y);
            Console.WriteLine("Price:" + ship.price);
            Console.WriteLine("Speed:" + ship.speed);
            Console.WriteLine("Passengers:" + ship.passengers);
            Console.WriteLine("Port:" + ship.port);
            Console.WriteLine("Years:"+ship.years);

            Console.WriteLine("Plane spec:");
            Console.WriteLine("Coordinates: x = " + car.x + "y = " +car.y);
            Console.WriteLine("Price:" + car.price);
            Console.WriteLine("Speed:" + car.speed);
            Console.WriteLine("Years:" + car.years);

            Console.ReadLine();
        }
    }
}
