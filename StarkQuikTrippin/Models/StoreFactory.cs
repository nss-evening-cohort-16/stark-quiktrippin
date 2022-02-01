using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{

    /// YEARLY totals quarter totals x 4
    // yearly retail totals of all employees
    internal class StoreFactory
    {
        public Store BuildNewStore()
        {
            bool successful = false;
            int parsedStoreNumber = 0;

            while (!successful)
            {

                var question1 = "Please Enter Store Number(leave blank to end):";
                Console.WriteLine(question1);
                var storeNumber = Console.ReadLine();
                successful = int.TryParse(storeNumber, out parsedStoreNumber);

                if (storeNumber == "")
                {
                    return new Store(0, 0, 0, 0, 0);
                }
            }
            successful = false;
            double parsedGasYearly = 0; 
            double parsedGasCurrent = 0;
            double parsedRetailYearly = 0;
            double parsedRetailCurrent = 0;

            while (!successful)
            {
                Console.WriteLine($"Enter {parsedStoreNumber}'s Gas Yearly Total:");
                var gasYearly = Console.ReadLine(); 
                successful = double.TryParse(gasYearly, out parsedGasYearly);
            }
            successful = false;
            while (!successful)
            {

                Console.WriteLine($"Enter {parsedStoreNumber}'s Gas Current Total:");
                var gasCurrent = Console.ReadLine();
                successful = double.TryParse(gasCurrent, out parsedGasCurrent);
            }
            successful = false;
            while (!successful)
            {
                Console.WriteLine($"Enter {parsedStoreNumber}'s Retail Yearly Total:");
                var retailYearly = Console.ReadLine();
                successful = double.TryParse(retailYearly, out parsedRetailYearly);
            }
            successful = false;
            while (!successful)
            {
                Console.WriteLine($"Enter {parsedStoreNumber}'s Retail Current Total:");
                var retailCurrent = Console.ReadLine();
                successful = double.TryParse(retailCurrent, out parsedRetailCurrent);
            }

            var retVal = new Store(parsedStoreNumber, parsedGasYearly, parsedGasCurrent, parsedRetailYearly, parsedRetailCurrent);
            return retVal;
        }
        static List<Store> _storeTeam = new List<Store>();

        public void AddEmployeeToStore(int storeNumber)
        {

        }
        static List<Store> _stores = new List<Store>();
        // add store to list 
        public List<Store> GetStores()

        {
            throw new NotImplementedException();
        }
    }
}

// add employees to storeTeam list