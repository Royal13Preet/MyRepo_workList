using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int total = 3;
            Person[] person = new Person[total];
            for (int i = 0; i < total; i++)
            {
                person[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            
            }
            for (int i = 0; i < total; i++) {
                Console.WriteLine(person[i].ToString());
            }

            for(int i = 0; i<total; i++)
            {
                Console.WriteLine(person[i].ToString());
            }

        }
    }
    public class Person
    {

        
        public string Name { get; set; }
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}