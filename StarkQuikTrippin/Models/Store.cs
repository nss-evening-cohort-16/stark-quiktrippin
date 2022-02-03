using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class Store
    {
        public Store(int storeNumber, double gasYearly, double gasCurrent, double retailYearly, double retailCurrent, string storeManger, string assistantManager, string associate, double storeManagerSales, double assistantManagerSales, double associateSales)
        {
            StoreNumber = storeNumber;
            GasYearly = gasYearly;
            GasCurrent = gasCurrent;
            RetailYearly = retailYearly;
            RetailCurrent = retailCurrent;
            StoreManager = storeManger;
            AssistantManager = assistantManager;    
            Associate = associate;
            StoreManagerSales = storeManagerSales;
            AssistantManagerSales = assistantManagerSales;
            AssociateSales = associateSales;
        }
        public Store(int storeNumber)
        {
            storeNumber = StoreNumber;
        }
        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public string Associate { get; set; } 
        public int StoreNumber { get; set; }
        public double GasYearly { get; set; }
        public double GasCurrent { get; set; }

        public double RetailYearly { get; set;}

        public double RetailCurrent { get; set; }
        public double StoreManagerSales { get; set; }
        public double AssistantManagerSales { get; set; }
        public double AssociateSales { get; set; }
        public List <Employee> storeStaff { get; set; } = new List<Employee> ();
        public void HireEmployees(Employee employee)

        {
            storeStaff.Add(employee);
        }
    }

}
