using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtaxi
{
     public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
                if (OnDuty == true)
            {
                Console.WriteLine("On Duty: Yes");
            }
                else if (OnDuty == false)
            {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number Of Passanger: {0}", NumPassanger);
        }
        public void PickUpPassanger()
        {
            Console.WriteLine("\n{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPasanger()
        {
            Console.WriteLine("{0} Selsai Mengantar Penumpang", DriverName);
        }
    }
}
