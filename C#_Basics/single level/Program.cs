using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace single_level
{
    public class branches
    {
        public int branchcode;
        public String branchname;
       
        public branches()
        {
            Console.WriteLine("enter a branch code");
            branchcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a branch name");
            branchname = Console.ReadLine();

        }
        //p.Div(5,7);
        public branches(branches obj)
        {
            branchcode = obj.branchcode;
            branchname = obj.branchname;
        }
    }
   //200 --> ok response
   //201 --> created, createdAtAction, CreatedAtRoute
   //202 --> Accepted->, AcceptedAtAction->include location header, AcceptedAtRoute-> include location header with route
   //204 --> noContent --> succefull update and delete
     class emp : branches
    {
        int empid;
        int empage;
        string empname;
        string empaddress;
        //branches bobj;

        public emp() : base()
        {
            Console.WriteLine("Enter employee ID:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee age:");
            empage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            empname = Console.ReadLine();
            Console.WriteLine("Enter employee address:");
            empaddress = Console.ReadLine();
        }

        public emp(emp obj) : base(obj) 
        {
            empid = obj.empid;
            empage = obj.empage;
            empname = obj.empname;
            empaddress = obj.empaddress;
            //branchcode = obj.branchcode;
            //branchname = obj.branchname;
        }

        public void Display()
        {
            Console.WriteLine(empid);
            Console.WriteLine(empage);
            Console.WriteLine(empname);
            Console.WriteLine(empaddress);
            Console.WriteLine(branchcode);
            Console.WriteLine(branchname);
        }

        
    }
       class employee
    {
        public static void Main(string[] args)
        {
            //branches bobj = new branches();
            emp emp1 = new emp();
            emp1.Display();

            emp emp2 = new emp(emp1);
            emp2.Display();

            Console.ReadKey();
        }

    }  
       
}

