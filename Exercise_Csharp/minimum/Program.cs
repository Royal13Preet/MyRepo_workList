using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
                Console.WriteLine("The Minimum Range of the Decimal Data " + "Type is : {0} ", Decimal.MinValue);

                Console.WriteLine("The Minimum Range of the Float Data " + "Type is : {0} ", Single.MinValue);

                Console.WriteLine("The Minimum Range of the Decimal Data " + "Type is : {0} ", Double.MinValue);

                Console.WriteLine("Exponent Form : The Minimum Range of Decimal " + "Data Type  is : {0:E}", Decimal.MinValue);

                Console.WriteLine("Exponent Form : The Minimum Range of Float " + "Data Type  is : {0:E}", Single.MinValue);

                Console.WriteLine("Exponent Form : The Minimum Range of Double " + "Data Type  is : {0:E}", Double.MinValue);

            Console.ReadLine();
            
        }
    }
}
 