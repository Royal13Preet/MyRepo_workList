using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    
     public class A
    {
        void A_Method()
        {
            Console.WriteLine("Class A Method");
        }
    }

    public class B : A
    {
        public override void A_Method()
        {
            Console.WriteLine("Class B Method");
        }
    }
    
    public class C : A
    {
        public override void A_Method()
        {
            Console.WriteLine("Class C Method");
        }
    }

    public class D : B
    {
        public override void A_Method()
        {
            Console.WriteLine("Class D Method");
        }
    }
    class methodov
    {
        public static void Main()
        {
            D objD = new D();
            objD.A_Method(); 
        }

    }

    
}

