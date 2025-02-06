using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Saturdaywork
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = Convert.ToInt32(Console.ReadLine());
            BigInteger b = 1;
            for (BigInteger i = 1; i <= a; i++)
            {
                b = i * b;

            }
            Console.WriteLine(b);
            Console.ReadLine();

        }
       
    }
}

