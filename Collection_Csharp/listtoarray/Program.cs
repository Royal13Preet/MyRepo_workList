using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listtoarray
{
    public class Program
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

            List<Employee> list = new List<Employee>();
            list.Add(employee);
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);

            foreach (Employee i in list)
            { 
                Console.WriteLine(i.Id+" "+ i.Name+ " "+i.Age);
            }

            
            Employee[] myArray = list.ToArray();
           
            Console.WriteLine("Array elements:");
            foreach (Employee item in myArray)
            {
                Console.WriteLine(item.Id + "  " + item.Name+ " " +item.Age);
            }


        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
