using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultconst
{
 
        class multiplication
        {
            int a, b;

            // default Constructor 
            public multiplication()
            {
                a = 10;
                b = 5;
            }

            // Main Method 
            public static void Main()
            {

                // an object is created,  
                // constructor is called 
                multiplication obj = new multiplication();

                Console.WriteLine(obj.a);
                Console.WriteLine(obj.b);

                Console.WriteLine("The result of multiplication is: "
                                                    + (obj.a * obj.b));
            }

        }
 
}
    