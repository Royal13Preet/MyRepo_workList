using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outandref
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Title = "Understanding the class";



            //    Console.Beep();
            //    int g;
            //    sum(out g);
            //    Console.WriteLine("The some of ; {0}", g);
            //}

            //public static void sum(out int g)
            //{
            //    g = 20;
            //    g += g;
            //}

           
            
                string str = "hi";
                setValue(ref str);

                int ints;
                sum(out ints);
            }

            public static void setValue(ref string str1)
            {
                str1 = "bye";
                Console.WriteLine(str1);

            }
            public static void sum(out int ints)
            {
                ints = 7;
                ints = ints + 7;
                Console.WriteLine(ints);
            }
        
    }

}


      


