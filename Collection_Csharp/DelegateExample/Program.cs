using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace DelegateExample
{
    class Area
    {
        //public int rectangle(int l, int b)
        //{
        //    return (l * b);
        //}

        //public static int triangle(int l, int b)
        //{
        //    return (l + b);
        //}
    }

    public delegate int AreaDelegate(int l, int b);

    //public delegate float CircleDelegate(float r);

    class Program
    {

        public static void Main(string[] args)
        {
            Area area = new Area();

            AreaDelegate obj1 = delegate (int l, int b)
            {
                return (l + b);
            };
            
            int a = obj1(10, 45);
            Console.WriteLine(a);
         
       


            //AreaDelegate obj2 = new AreaDelegate(Area.triangle);

            //AreaDelegate obj3 = obj1 + obj2;


            //employee class
            //name,id,gender,salary
            //create a collection of employee, assign a values
            //take a method inside a class
            //if emp salary>5000 it has to display
            //Pass the salary methods has delegate

            //obj3.Invoke(7,8);
            //Console.WriteLine(obj3.Invoke(7,8));
            //Console.WriteLine(obj3.Invoke(7, 8));

            //
            //foreach (AreaDelegate del in obj3.GetInvocationList())
            //{
            //    {
            //        int result = del.Invoke(7, 8);
            //        Console.WriteLine(result);
            //    }

            //}
        }
    }
}
