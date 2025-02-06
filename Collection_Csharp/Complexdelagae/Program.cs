using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexdelagate
{

        public class Program
        {
            
            public delegate bool EmployeeFilter(Employee employee);

        static void Main(string[] args)
        {


            Employee employee1 = new Employee() { Id = 1001, Name = "Preet", Gender = "Female", Salary = 900000 };
            Employee employee2 = new Employee() { Id = 1002, Name = "Khush", Gender = "Male", Salary = 300000 };
            Employee employee3 = new Employee() { Id = 1003, Name = "nave", Gender = "Female", Salary = 400000 };
            Employee employee4 = new Employee() { Id = 1004, Name = "Priya", Gender = "Female", Salary = 250000 };
            Employee employee5 = new Employee() { Id = 1005, Name = "Sid", Gender = "Male", Salary = 500000 };
            Employee employee6 = new Employee() { Id = 1006, Name = "manju", Gender = "Male", Salary = 888800 };
            Employee employee7 = new Employee() { Id = 1006, Name = "kavya", Gender = "FeMale", Salary = 708800 };
            Employee employee8 = new Employee() { Id = 1007, Name = "dhaniya", Gender = "Female", Salary = 98798 };

           

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee8);


            //var aa = employees.OrderBy(x => x.Id);
            //foreach(var i in aa)
            //{
            //    Console.WriteLine($"{ i.Name},{i.Id}");
            //}

            //bool Females = employees.TrueForAll(x => x.Gender == "Female");
            //Console.WriteLine($"Are all employees female {Females}");

            //var readOnlyEmployees = employees.AsReadOnly();

            //Console.WriteLine("Read-Only");
            //foreach (var employee in readOnlyEmployees)
            //{
            //    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            //}


            //employees.Add(employee6);

            //Console.WriteLine("After Adding");
            //foreach (var employee in readOnlyEmployees)
            //{
            //    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            //}


            
            Console.WriteLine($"Before TrimExcess:");
            Console.WriteLine($"Count: {employees.Count}");
            Console.WriteLine($"Capacity: {employees.Capacity}");

            employees.TrimExcess();

            Console.WriteLine($"After TrimExcess:");
            Console.WriteLine($"Count: {employees.Count}");
            Console.WriteLine($"Capacity: {employees.Capacity}");
            
            employees.Add(employee6);
            employees.Add(employee7);

            Console.WriteLine($"\nAfter Adding More Elements:");
            Console.WriteLine($"Count: {employees.Count}");
            Console.WriteLine($"Capacity: {employees.Capacity}");


            //EmployeeFilter filter = delegate (Employee employee)
            //{
            //    return employee.Salary > 500000;
            //};

            //EmployeeFilter filter = (Employee employee) => { return employee.Salary > 500000; };


            //foreach (var employee in employees)
            //{
            //    if (filter(employee))
            //    {

            //        Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            //    }
            //}
            Console.ReadLine();
        }
        
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }

           
        }
    }

