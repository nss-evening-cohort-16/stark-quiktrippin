using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class DistrictFactory
    {
        public District BuildNewDistrict()
        {
            var question1 = "Enter District name (leave blank to end):";
            Console.WriteLine(question1);
            var name = Console.ReadLine();

            if (name == "")
            {
                return new District("", "");
            }

            var question2 = $"Enter {name} districts's Mangers name:";
            Console.WriteLine(question2);
            var districtManagerName = Console.ReadLine();

            var retVal = new District(name, districtManagerName);
            return retVal;

        }

        // add stores to district
        public List<District> GetDistricts()
        {
            throw new NotImplementedException();
        }

        public void SaveNewDistrict(District district)
        {
            throw new NotImplementedException();
        }
    }
}
