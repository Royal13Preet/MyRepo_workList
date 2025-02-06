using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass1
{
    abstract class Program
    {
        public string Empadd, Empname;
        public int EmpId, EMpage;
        
        public abstract void GetEmpData();

        public virtual void getdisplaydat()
        {
            Console.WriteLine(Empadd);
            Console.WriteLine(Empname);
            Console.WriteLine(EmpId);
            Console.WriteLine(EMpage);
        }

    }

    class EMployee : Program
    {
        public decimal ca, bonus;
        public override void GetEmpData()
        {
            Console.WriteLine("enter a employeee ID");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a employee name");
            Empname = Console.ReadLine();
            Console.WriteLine("enter a employee age");
            EMpage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a ca");
            ca = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter a bonus");
            bonus = Convert.ToDecimal(Console.ReadLine());



        }

        public override void getdisplaydat()

        {
            Console.WriteLine(Empname);
            Console.WriteLine(EmpId);
            Console.WriteLine(EMpage);
            Console.WriteLine(ca);
            Console.WriteLine(bonus);

        }
    }

    class example
    {
        public static void Main(string[] args)
        {
            EMployee obj = new EMployee();
            obj.GetEmpData();
            obj.getdisplaydat();
        }
    }
}
