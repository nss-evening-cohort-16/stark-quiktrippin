using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class StoreManager : Employee
    {
        public StoreManager(string name, string title, double retailSales) : base(name, title, retailSales)
        {
        }
    }
}
