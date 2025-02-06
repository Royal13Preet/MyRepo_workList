using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeCasting
{
    public class Program
    {
        static void Main(string[] args)
        {


          

                //Integer Class
                Console.Write("enter a integer: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);

                //String Class
                Console.Write("enter a string: ");
                string b = Console.ReadLine();
                Console.WriteLine(b);

                //Char class
                Console.Write("enter a char: ");
                char c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(c);

                //Boolean class
                Console.Write("enter a bool: ");
                bool isMale = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(isMale);

                //Long class
                Console.Write("enter a long: ");
                long d = long.Parse(Console.ReadLine());
                Console.WriteLine(d);

                //Float class
                Console.Write("enter a float: ");
                float f = float.Parse(Console.ReadLine());
                Console.WriteLine(f);

                //Short class
                Console.Write("enter a short: ");
                short e = short.Parse(Console.ReadLine()); //It is showing as int value
                Console.WriteLine(e);

                Console.Write("enter a short: ");
                short t = Convert.ToInt16(Console.ReadLine()); //It is showing as int value
                Console.WriteLine(t);

                //Double class
                Console.Write("enter a Double: ");
                double g = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(g);




            
        }
    }



}
    