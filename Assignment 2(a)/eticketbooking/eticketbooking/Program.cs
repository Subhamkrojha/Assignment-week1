using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eticketbooking
{
    class bookticket
    {
        string name;
        string place;
        string destination;
        int age;
        string date;
     public void getpassengerdata()
        {
            Console.WriteLine("Enter passenger name in block:");
            name=Console.ReadLine();
            Console.WriteLine("Enter the boarding place:");
            place=Console.ReadLine();
            Console.WriteLine("Enter destination :");
            destination=Console.ReadLine();
            Console.WriteLine("Enter the age of the Passengers: ");
            age=Console.Read();
            Console.WriteLine("Enter the travel Date in dd/mm/yyyy form:");
            date=Console.ReadLine();
        }
    }
    class ebookticket : bookticket
    {
        string Flightname;
        int numberofflight;
        public void Flightdetails()
        {
            Console.WriteLine("Enter Flightnaame");
            Flightname=Console.ReadLine();
            Console.WriteLine("Enter number of flights available");
            numberofflight = Convert.ToInt32(Console.ReadLine());
            getpassengerdata();
           


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ebookticket E1 = new ebookticket();
            E1.Flightdetails();
            Console.ReadLine();

        }
    }
}
