using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintenanceofflight
{
    class maintenance
    {
        string staff;
        int flightnumber;
        int flightundermaintenance;
        public void getstaffdata()
        {
            Console.WriteLine("Enter staff personel name:");
            staff = Console.ReadLine();
            Console.WriteLine("Enter Flight Name:");
            flightnumber= Convert.ToInt32(Console.ReadLine());
            check();

        }
        public void check()
        {
            Console.WriteLine("Eneter the flight which is under maintenance:");
            flightundermaintenance = Convert.ToInt32(Console.ReadLine());
            if (flightnumber == flightundermaintenance)
            {
                Console.WriteLine("The flight is under maintenance an it cannot be used by passengers Sorry for inconvinience caused");
            }
            else
            {
                Console.WriteLine("We are ready to fly please tighten your seat belts");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            maintenance M1 = new maintenance();
            M1.getstaffdata();
            Console.ReadLine();
        }
    }
}
