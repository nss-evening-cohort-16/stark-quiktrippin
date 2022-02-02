using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class DistrictManager : Employee
    {
        public DistrictManager(string name, string title, double retailSales) : base(name, title, retailSales)
        {
        }
    }
}
