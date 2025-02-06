using System;
using AssemblyOne;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            
            Console.WriteLine(Id); 
        }
    }
    public class AnotherAssemblyClass2
    {
        public void Dispplay3()
        {
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); 

        }
    }
}
