using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarkQuikTrippin.Models;

namespace StarkQuikTrippin.Models
{
    internal class MenuSimulator
    {

        public void ShowMenu()
        {
            Console.WriteLine(@"
QuikTrip Management Systems

1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a Store/District
5. Exit

");
        }

        public void EnterStoreDistrictMenu()
        {
          
            Console.WriteLine(@"
Enter district name and then add stores.
");
        }

    

        public void StartApp()
        {
            Console.Clear();
            ShowMenu();
            GetUserInput();
        }



        private void GetUserInput()
        {
            bool successful = false;
            var parsedInput = 0;
            while (!successful)
            {
                var input = Console.ReadLine(); 
                successful = int.TryParse(input, out parsedInput);

                switch (parsedInput)
                {
                    case 1:
                        Console.WriteLine("Enter District Sales");
                        break;
                    case 2:
                        GenerateDisttrictReport();
                        break;
                    case 3:
                        CreateEmployee();
                        break;
                    case 4:
                        EnterStoreDistrictMenu();
                        CreateDistrict();
                        break;
                    case 5: break;
                    default:
                        Console.WriteLine("Please Enter 1-5");
                        break;
                }
            }
        }

        public void CreateStore()
        {
            var store1 = new StoreFactory();
            var buildingStore = true;
            while (buildingStore)
            {
                var newStore = store1.BuildNewStore();
                if (newStore.StoreNumber != 0)
                {
                    _stores.Add(newStore);

                }
                else
                {
                    buildingStore = false;
                }
            }
        }



        public void CreateDistrict()
        {
            var district1 = new DistrictFactory();
           
            
                var newDistrict = district1.BuildNewDistrict();
               
                    _districts.Add(newDistrict);
                    CreateStore();
            StartApp();

        }
        private List<District> _districts = new List<District>();
        private List<Store> _stores = new List<Store>();
        private List<Employee> _employees = new List<Employee>();
           
       // set 1: Getting Store Number 
       // set 2: 
        public void CreateEmployee() {
            //{   var employees = new List<Employee>();
            //    var storeStaff = new Dictionary<Store, List<Employee>>();
            bool successful = false;
            var parsedInput = 0;
            while (!successful)
            {
                Console.WriteLine("Enter employee store number:");
                var input = Console.ReadLine();
                successful = int.TryParse(input, out parsedInput);

                var employee1 = new EmployeeFactory();
                var buildingEmployee = true;
                while (buildingEmployee)
                {
                    var newEmployee = employee1.BuildNewEmployee();
                    if (newEmployee.EmployeeName != "")
                    {
                        _employees.Add(newEmployee);
                    }
                    else buildingEmployee = false;


                    foreach (Store store in _stores)
                    {
                        Console.WriteLine(store.StoreNumber);
                        if (parsedInput == store.StoreNumber)
                        {
                            store.HireEmployees(newEmployee);
                        }
                        if (newEmployee.Title == "Store Manager")
                        {
                            store.StoreManager = newEmployee; 
                        } else if (newEmployee.Title == "Assistant Manager")
                        {
                            store.AssistantManager = newEmployee;
                        } else if (newEmployee.Title == "Associate")
                        {
                            store.Associate = newEmployee;
                        }
                     foreach (Employee employee in store.storeStaff)
                        {
                            Console.WriteLine(employee.EmployeeName);
                        }
                        
                    }
                }
            }
            BackToMenu();
        }

        public void BackToMenu()
        {
            Console.WriteLine("Press 0 to go back to menu");
            bool successful = false;
            var parsedInput = 0;
            while (!successful)
            {
                var input = Console.ReadLine();
                successful = int.TryParse(input, out parsedInput);
            }
            if (parsedInput == 0)
            {
                StartApp();
            }

        }


        public void GetDistricts()
        {
            Console.Clear();
            foreach (var district in _districts)
            {
                Console.WriteLine($@"

{district.Name}
{district.DistrictManagerName}");
            }
        }
        
       
    public void GenerateDisttrictReport()
        { Console.WriteLine($@"
District Sales Report
");
            foreach (Store store in _stores)
            {
                Console.WriteLine($@"
Store {store.StoreNumber}
----------------------------------
1. Store Manager
   {store.StoreManager.EmployeeName}
     Retail Sales: {store.StoreManager.RetailSales}

2. Assistant Manager
   {store.AssistantManager.EmployeeName}
     Retail Sales: {store.AssistantManager.RetailSales}

3. Associate
   {store.Associate.EmployeeName}
     Retail Sales: {store.Associate.RetailSales}

GasYearly: {store.GasYearly}
Gas Current quarter: {store.GasCurrent}
Retail Yearly: {store.RetailYearly}
Retail Current quarter: {store.RetailCurrent}



");
            }

        }


    }
}
