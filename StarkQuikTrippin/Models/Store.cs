using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class Store
    {
        public Store(int storeNumber)
        {
            StoreNumber = storeNumber;
        }

        public int StoreNumber { get; set; }
        public int GasYearly { get; set; }
        public int GasCurrent { get; set; }

        public int RetailYearly { get; set;}

        public int RetailCurrent { get; set; }
    }

}
//Sales for Store #518

//Gas Yearly: $1, 037, 648
//Gas Current quarter: $96, 117
//Retail Yearly: $1, 823, 294
//Retail Current quarter: $84, 445