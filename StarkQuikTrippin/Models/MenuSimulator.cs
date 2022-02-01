using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class MenuSimulator
    {
        public void ShowMenu()
        {
            Console.WriteLine(@"
QuikTrip Management Systems

1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a Store/District
5. Exit

");
        }
    }
}
