using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class Store
    {
        public Store(int storeNumber, double gasYearly, double gasCurrent, double retailYearly, double retailCurrent)
        {
            StoreNumber = storeNumber;
            GasYearly = gasYearly;
            GasCurrent = gasCurrent;
            RetailYearly = retailYearly;
            RetailYearly = retailCurrent;
        }

        public int StoreNumber { get; set; }
        public double GasYearly { get; set; }
        public double GasCurrent { get; set; }

        public double RetailYearly { get; set;}

        public double RetailCurrent { get; set; }
    }

}
//Sales for Store #518

//Gas Yearly: $1, 037, 648
//Gas Current quarter: $96, 117
//Retail Yearly: $1, 823, 294
//Retail Current quarter: $84, 445