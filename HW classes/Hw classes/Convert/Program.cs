using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Converter
    {
        public double usdRate;
        public double eurRate;
        public double rubRate;

        public Converter(double usdRate, double eurRate, double rubRate)
        {
            this.usdRate = usdRate;
            this.eurRate = eurRate;
            this.rubRate = rubRate;
        }

        public double UahToUsd(double uah)
        {
            return uah / usdRate;
        }

        public double UahToEur(double uah)
        {
            return uah / eurRate;
        }

        public double UahToRub(double uah)
        {
            return uah / rubRate;
        }

        public double UsdToUah(double usd)
        {
            return usd*usdRate;
        }
        public double EurToUah(double eur)
        {
            return eurRate * eur;
        }

        public double RubToUah(double rub)
        {
            return rubRate*rub;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 20.5;
            double eur = 22;
            double rub = 4.5;
            var converter = new Converter(usd,eur,rub);
            Console.WriteLine("Enter sum in usdRate (eurRate, rubRate):");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("UAH if USD:" + converter.UsdToUah(sum));
            Console.WriteLine("UAH if EUR:" + converter.EurToUah(sum));
            Console.WriteLine("UAH if RUB:" + converter.RubToUah(sum));

            Console.WriteLine("Enter sum in uah:");
            double sumUah = double.Parse(Console.ReadLine());

            Console.WriteLine("In USD:" + converter.UahToUsd(sumUah));
            Console.WriteLine("In EUR:" + converter.UahToEur(sumUah));
            Console.WriteLine("In RUB:"+ converter.UahToRub(sumUah));

            Console.ReadLine();
        }
    }
}
