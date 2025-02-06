using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList obj = new SortedList();
            //obj.Add(3, "etg");
            //obj.Add(58888, "dsugi");
            //obj.Add(53, "kj");
            //obj.Add(1, "dsjuh");
            //obj.Add(2, "fffcv");
            //obj.Add(9, "uyy");
            //obj.Add(0, "suig");
            //foreach (DictionaryEntry i in obj) 
            //{ 
            //    Console.WriteLine(i.Key+ " " +i.Value);
            //}

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


            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            
            employees.Add(employee4);
            employees.Add(employee2);
            foreach (Employee i in employees) {
                Console.WriteLine($"{i.Name},{i.Id},{i.Age}");
            }

            Console.WriteLine("after sorting");
            employees.Sort();
            foreach (Employee i in employees) {
                Console.WriteLine($"{i.Name},{i.Id},{i.Age}");
            }

        }
       
    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Employee obj)
        {
            if(this.Age > obj.Age) return -1;
            else if(this.Age < obj.Age)return 1;
            else return 0;
        }
    }
}
