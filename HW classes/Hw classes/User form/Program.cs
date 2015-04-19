using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace User_form
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public int years;
        public string date;
        public string setdata
        {
            get
            {
                return date; 
            }
        
        }

        public User(string date)
        {
            this.date = date;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string date = "21.03.1990";
            var user = new User(date);
            Console.WriteLine("Enter login:");
            user.login = Console.ReadLine();
            Console.WriteLine("Enter name:");
            user.name = Console.ReadLine();
            Console.WriteLine("enter surname:");
            user.surname = Console.ReadLine();
            Console.WriteLine("enter years:");
            user.years = int.Parse(Console.ReadLine());
            Console.WriteLine("enter date:");
            user.date = Console.ReadLine();
            Console.WriteLine("_______________________");
            Console.WriteLine("login:"+user.login);
            Console.WriteLine("name:"+user.name);
            Console.WriteLine("surname:"+user.surname);
            Console.WriteLine("years:"+user.years);
            Console.WriteLine("date:"+user.setdata);
            Console.ReadLine();


        }
        
        
    }
}
