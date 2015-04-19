using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        public int account;
        public string customer;
       
        private string article;
        private int quantity;
        private double pricePerUnit;


        public string MyArticle
        {
            get
            {
                return article;
            }
        }

        public int MyQuantity
        {
            get
            {
                return quantity;
            }
        }

        public double MyPricePerUnit
        {
            get
            {
                return pricePerUnit;
            }
        }

        public double PriceWithTax()
        {
            return MyQuantity*MyPricePerUnit*1.2;
        }

        public double PriceWithoutTax()
        {
            return MyQuantity*MyPricePerUnit*1;
        }

        public Invoice(int account, string customer)
        {
            this.account = account;
            this.customer = customer;
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(100500, "Petro");
            Console.WriteLine(invoice.PriceWithTax());
            Console.ReadLine();

        }
    }
}
