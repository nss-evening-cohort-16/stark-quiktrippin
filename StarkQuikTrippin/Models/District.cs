using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class District
    {
        public District(string name, string districtManagerName)
        {
            Name = name;
            DistrictManagerName = districtManagerName;

        }

        public string Name { get; set; }
        public string DistrictManagerName { get; set; }
    }
}
