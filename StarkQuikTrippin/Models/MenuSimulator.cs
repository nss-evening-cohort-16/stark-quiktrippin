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
                        Console.WriteLine("Add Employee");
                        break;
                    case 4:
                        EnterStoreDistrictMenu();
                        StoreDistricOption();
                        break;
                    case 5: break;
                    default:
                        Console.WriteLine("Please Enter 1-5");
                        break;
                }
            }
        }

        public void StoreDistricOption()
        { CreateDistrict();
                //GetStores();
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

        }
        public List<District> _districts = new List<District>();
        static List<Store> _stores = new List<Store>();
       
        
       
        
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
        
        
        
        
//        public void GetStores()

//        {
//            if (_stores.Count > 0)
//            {
//                Console.Clear();
//                foreach (var store in _stores)
//                {
//                    Console.WriteLine($@"
//Store Number: {store.StoreNumber}

//");
//                    Console.Clear();
//                    StartApp();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Please add Stores first");
//                EnterStoreDistrictMenu();
//                StoreDistricOption();
//            }
//        }
    public void GenerateDisttrictReport()
        { Console.WriteLine($@"
District Sales Report
");
            foreach (Store store in _stores)
            {
                Console.WriteLine($@"
{store.StoreNumber}
----------------------------------
1. Store Manager


2. Assistant Manager


3.Associate


GasYearly: {store.GasYearly}
Gas Current quarter: {store.GasCurrent}
Retail Yearly: {store.RetailYearly}
Retail Current quarter: {store.RetailCurrent}



");
            }
        }


    }
}
