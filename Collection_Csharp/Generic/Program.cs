using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    
        public class GenericClass<T> 
        {
            public T Message;
            public void GenericMethod(T Param1, T Param2)
            {
                Console.WriteLine($"Message: {Message}");
                Console.WriteLine($"Param1: {Param1}");
                Console.WriteLine($"Param2: {Param2}");
            }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string Location { get; set; }
        }

        class Program
        {
            static void Main()
            {
                // Instantiate Generic Class with Constraint
                GenericClass<string> stringClass = new GenericClass<string>();
                stringClass.Message = "Welcome to DotNetTutorials";
                stringClass.GenericMethod("Anurag Mohanty", "Bhubaneswar");

                GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();
                Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
                Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
                Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };
                EmployeeClass.Message = emp1;
                EmployeeClass.GenericMethod(emp2, emp3);

                // The following statement will giveCompile Time Error as int is a value type, not reference type
                GenericClass<int> intClass = new GenericClass<int>();  
                Console.ReadKey();
            }
        }
    }



