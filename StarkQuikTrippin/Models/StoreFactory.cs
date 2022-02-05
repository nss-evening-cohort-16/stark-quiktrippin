using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{

 
    internal class StoreFactory
    {
        public Store BuildNewStore()
        {
            bool successful = false;
            int parsedStoreNumber = 0;

            while (!successful)
            {

                var question1 = "Please Enter Store Number(type 0 to end):";
                Console.WriteLine(question1);
                var storeNumber = Console.ReadLine();
                successful = int.TryParse(storeNumber, out parsedStoreNumber);

                if (storeNumber == "0")
                {
                    return new Store(0, 0, 0, 0, 0);
                }
            }
            successful = false;

            //Console.WriteLine("Please enter store manager name:");
            //var storeManager = Console.ReadLine();

            //Console.WriteLine("Please enter assistant store manger name:");
            //var assistantManager = Console.ReadLine();

            //Console.WriteLine("Please enter associate name");
            //var associate = Console.ReadLine();

            double parsedGasYearly = 0; 
            double parsedGasCurrent = 0;
            double parsedRetailYearly = 0;
            double parsedRetailCurrent = 0;
            //double parsedStoreManagerSales = 0;
            //double parsedAssistantMangerSales = 0;
            //double parsedAssociateSales = 0;
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
            successful = false;
            //while (!successful)
            //{
            //    Console.WriteLine($"Enter Store Manager {storeManager}'s sales:");
            //    var storeMangerSales = Console.ReadLine();
            //    successful = double.TryParse(storeMangerSales, out parsedStoreManagerSales);
            //}
            //successful = false;
            //while (!successful)
            //{
            //    Console.WriteLine($"Enter Assistant Manager {assistantManager}'s sales: ");
            //    var assistantManagerSales = Console.ReadLine();
            //    successful = double.TryParse(assistantManagerSales, out parsedAssistantMangerSales);
            //}
            //successful = false;
            //while(!successful)
            //{
            //    Console.WriteLine($"Enter Associate {associate}'s sales:");
            //    var associateSales = Console.ReadLine();
            //    successful = double.TryParse(associateSales, out parsedAssociateSales);
            //}

            var retVal = new Store(parsedStoreNumber, parsedGasYearly, parsedGasCurrent, parsedRetailYearly, parsedRetailCurrent);
            return retVal;
        }

        
        
      

       
}
    }


