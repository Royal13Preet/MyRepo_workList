using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Preet",
                Age = 21
            };

            Employee employee1 = new Employee()
            {
                Id = 2,
                Name = "Khushi",
                Age = 24
            };
            Employee employee2 = new Employee()
            {
                Id = 3,
                Name = "priya",
                Age = 25
            };
            Employee employee3 = new Employee()
            {
                Id = 4,
                Name = "Sid",
                Age = 45
            };
            Employee employee4 = new Employee()
            {
                Id = 5,
                Name = "navee",
                Age = 34
            };

            Employee employee5 = new Employee()
            {
                Id = 6,
                Name = "manju",
                Age = 18
            };
            
            Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            dic.Add(employee.Id, employee);
            dic.Add(employee1.Id, employee1);
            dic.Add(employee2.Id, employee2);
            dic.Remove(employee1.Id);
            int cu = dic.Count();
            Console.WriteLine(cu);
            foreach (KeyValuePair<int, Employee> kvp in dic) 
            { 
                Console.WriteLine(kvp.Key + " " +kvp.Value.Name +" " +kvp.Value.Age);
            }

        //    Employee[] emplo = new Employee[4];
        //    emplo[0] = employee;
        //    emplo[1] = employee1;
        //    emplo[2] = employee2;
        //    emplo[3] = employee3;
        //    Console.WriteLine("Array Element is");
        //    foreach (Employee emp in emplo) 
        //    {
        //        Console.WriteLine(emp.Id+ " " +emp.Name+ " "+emp.Age);
        //    }

        //    Console.WriteLine("The list elements");
        //    List<Employee> employees = emplo.ToList();
           
            
        //    foreach (Employee emp in employees) 
        //    {
        //        Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Age);
        //    }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
