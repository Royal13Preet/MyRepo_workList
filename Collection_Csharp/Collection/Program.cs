using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    
    class Customer
    {
        public int Id { get; set; }
        public Customer(int id)
        {
            Id = id;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {

            Customer a = new Customer(1);
            Customer b = new Customer(2);
            a = b;
            Customer c = new Customer(a.Id + b.Id);
            b = c;
            Console.WriteLine("{0},{1},{2}", a.Id, b.Id, c.Id);
        }
    }


 }
        

