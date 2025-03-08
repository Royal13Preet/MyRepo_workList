using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmeth
{
    internal class Program
    {
        int age;
        static int id;
        string name;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter the age");
            p.age = Convert.ToInt32(Console.ReadLine());
            id = Convert.ToInt32(Console.ReadLine());

        }
    }
}
