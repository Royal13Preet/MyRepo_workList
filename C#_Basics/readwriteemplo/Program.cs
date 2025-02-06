using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace readwriteemplo
{
    internal class Program
    {
        int empid,  empage;
        double empsal;

        public int employee
        {
            set { empid = value; }
            get { return empid; }
        }

        public double employee1
        {
            set { empsal = value; }
            get { return empsal; }
        }
        public int employee3
        { set { empage = value; } 
            get { return empage; }
        }

    }
    class scene
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.employee = Convert.ToInt32(Console.ReadLine());
            p.employee1 = Convert.ToDouble(Console.ReadLine());
            p.employee3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The employee id is: " +p.employee);
            Console.WriteLine("The employee salary is: " +p.employee1);
            Console.WriteLine("the employee age is: " + p.employee3);
        }

    }
        
  }

