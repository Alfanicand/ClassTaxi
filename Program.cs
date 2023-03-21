using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Agus";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPasanger();

            Console.ReadKey();
        }
    }
}
