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

        // if 1 is entered enter district sales
        // if 2 s entered generate district report
        // if 3 is entered add a new employee
        // if 4 is entered add a store/district
            // another menu 1. enter district - if selected build new district
             //             2. enter store - if selected build new store
        // 5. if selected Exit applcation


    }
}
