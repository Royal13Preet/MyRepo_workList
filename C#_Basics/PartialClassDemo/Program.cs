using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PartialEmployee emp = new PartialEmployee
            {
                FirstName = "Pranaya",
                LastName = "Rout",
                Salary = 100000,
                Gender = "Male"
            };
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}
