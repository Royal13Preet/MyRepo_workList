using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //Creating Hashtable collection using collection-initializer syntax
            Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
             };
            

            string EmployeeName = (string)employee["Name"]; //Cast to String
            int EmployeeSalary = (int)employee["Salary"];   //Cast to Int

            Console.WriteLine("Before Updating Name and Salary");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");

            //Updating the Name and Salary
            employee["Name"] = "Smith"; //Update value of Name key
            employee["Salary"] = 5000; //Update value of Salary key

            Console.WriteLine("\nAfter Updating Name and Salary");
            EmployeeName = (string)employee["Name"];
            EmployeeSalary = (int)employee["Salary"];

            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");

            Console.ReadKey();
        }
    }
    
}

