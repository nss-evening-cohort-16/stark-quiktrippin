using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarkQuikTrippin.Models;

namespace StarkQuikTrippin.Models
{
    internal class DistrictFactory
    {
       

        public District BuildNewDistrict()
        {
   
            var question1 = "Enter District name:";
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

       
    }
}
