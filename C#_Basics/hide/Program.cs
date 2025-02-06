using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hide
{
    internal class Program
    {

        //public class Parent
        //{
        //    public virtual void Show()
        //    {
        //        Console.WriteLine("Parent Class Show Method");
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine("Parent Class Display Method");
        //    }
        //}
        //public class Child : Parent
        //{
        //    //Method Overriding
        //    public override void Show()
        //    {
        //        Console.WriteLine("Child Class Show Method");
        //    }

        //    //Method Hiding/Shadowing
        //    public new void Display()
        //    {
        //        Console.WriteLine("Child Class Display Method");
        //    }
        //}

        //class Program11
        //{
        //    static void Main(string[] args)
        //    {
        //        Parent obj = new Child();
        //        obj.Show();
        //        obj.Display();

        //        Console.ReadKey();
        //    }
        //}
        public static void Main(string[] args)
        {
            string str1 = "Hi";
            string str2 = String.Copy(str1);
            Console.WriteLine(object.ReferenceEquals(str1,str2));    
        }
    }

 
    //public class Child : Parent
    //{
    //    //Method Overriding
    //    public override void Show()
    //    {
    //        Console.WriteLine("Child Class Show Method");
    //    }

    //    //Method Hiding/Shadowing
    //    public new void Display()
    //    {
    //        Console.WriteLine("Child Class Display Method");
    //    }
    //}
    //class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        Child obj = new Child();
    //        obj.Show();
    //        obj.Display();
    //        Console.ReadKey();
    //    }
    //}
}
  

