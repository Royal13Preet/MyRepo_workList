using System;
using System.Collections.Generic;

using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        public static bool IsOlderThan22(Employee e)
        {
            return e.Age > 22;
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1001,
                Name = "preet",
                Age = 21
            };

            Employee employee2 = new Employee()
            {
                Id = 1002,
                Name = "khush",
                Age = 22
            };
            
            Employee employee3 = new Employee()
            {
                Id = 1003,
                Name = "pooja",
                Age = 23
            };

            Employee employee4 = new Employee()
            {
                Id = 1004,
                Name = "priya",
                Age = 24
            };
            Employee employee5 = new Employee()
            {
                Id = 1005,
                Name = "sumedh",
                Age = 24
            };



            List<Employee> list = new List<Employee>();
            list.Add(employee);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            list.Add(employee5);

            bool a = list.TrueForAll(x =>(int) x.Id);
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }
            //foreach (Employee emp in list)
            //{

            //    Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Age);

            //}

            //list.Sort();

            //Console.WriteLine("after sorting");
            //foreach (Employee emp in list)
            //{
            //    Console.WriteLine(emp.Name + " " + emp.Age);
            //}

            //// we insert the the element by index
            //list.Insert(2, employee3);

            ////It removes the element
            //list.Remove(employee);

            ////It removes the element using index
            //list.RemoveAt(3);

            ////It check atleast one item in list matches a condition
            //bool v = list.Exists(e => e.Age > 22);
            //Console.WriteLine($"Is there an employee older than 22? {v}");


            ////It tell us to the element is present or not
            //bool a = list.Contains(employee);
            //Console.WriteLine(a);

            ////Finds the first item that matches a condition.
            //Employee found = list.Find(e => e.Age == 24);
            //Console.WriteLine($"Found Employee: {found?.Name ?? "Not found"}");

            ////Finds all items that match a condition.
            //List<Employee> foundAll = list.FindAll(e => e.Age > 22);
            //Console.WriteLine("Employees older than 22:");
            //foreach (var emp in foundAll)
            //{
            //    Console.WriteLine($"{emp.Name} (Age: {emp.Age})");
            //}



            ////Finds all items that match a condition

            //List<Employee> foundAll1 = list.FindAll(IsOlderThan22);

            //Console.WriteLine("Employees older than 22:");
            //foreach (var emp in foundAll1)
            //{
            //    Console.WriteLine($"{emp.Name} (Age: {emp.Age})");
            //}



            ////Finds the index of the first match.
            //int index = list.FindIndex(e => e.Name == "Pooja");
            //Console.WriteLine($"Index of Pooja: {index}");


            ////it returns the index of the last matching element
            
           //Console.WriteLine(list.FindLastIndex(e => e.Age == 24));
          


            ////Finds the last item that matches a condition.
            //Employee last = list.FindLast(e => e.Age < 25);
            //Console.WriteLine($"Last Employee younger than 25: {last?.Name}");


            //// Other methods
            //int count = list.Count;                   // Get number of items in the list
            //Console.WriteLine(count);
            //list.Clear();                             // Remove all items from the list
            //bool isEmpty = list.Count == 0;           // Check if the list is empty
            //Console.WriteLine(isEmpty);






            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        

        
       

    }
}
