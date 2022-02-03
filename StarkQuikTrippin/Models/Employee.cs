using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarkQuikTrippin.Models
{
    internal class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeStore { get; set; }

        public string EmployeeDistrict { get; set; }

        public string Title { get; set; }
        public double RetailSales { get; set; }

        public Employee(string name, string title, double retailSales)
        {
            EmployeeName = name;
            Title = title;
            RetailSales = retailSales;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($@"
{Title}
{EmployeeName}
Retail Sales: {RetailSales}
");
        }


        public void CreateEmployee()
        {
            var employee1 = new EmployeeFactory();
            var buildingEmployee = true;
            while (buildingEmployee)
            {
                var newEmployee = employee1.BuildNewEmployee();
                if (newEmployee.EmployeeName != "")
                {
                    //add employee to store
                }
                else buildingEmployee = false;
            }
        }
    }
}
// print employee info