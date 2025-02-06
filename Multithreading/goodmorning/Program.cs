using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodmorning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using inbuilt

            string str1 = "Good Morning Alexa";
            string str2 = str1.Replace("Morning", "Evening");
            Console.WriteLine(str2);

            //
            string str5 = "";
            string[] str7 = str1.Split(' ');
            foreach (string str3 in str7)
            {

                if (str3 == "Morning")
                {
                    str5 += "Evening";

                }
                else
                {
                    str5 += str3;
                }
           
            }
            Console.WriteLine(str5);


        }
}
}
