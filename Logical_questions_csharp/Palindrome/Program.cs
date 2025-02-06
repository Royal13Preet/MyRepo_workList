using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palin = "aba";
            string pali = "";
            for (int i = 0; i < palin.Length; i++)
            {
                pali = palin[i] + pali;

            }
            if (pali == palin)
            {
                Console.WriteLine("Its is palindrome");
            }
            else
            {
                Console.WriteLine("it does not palindrome");
            }

            //string a = "abscsgda";
            //string b = ""; 

            //for (int i = 0; i < a.Length; i++)
            //{
            //    bool isDuplicate = false;

                
            //    for (int j = 0; j < b.Length; j++)
            //    {
            //        if (a[i] == b[j])
            //        {
            //            isDuplicate = true; 
            //            break;
            //        }
            //    }

               
            //    if (!isDuplicate)
            //    {
            //        b += a[i];
            //    }
            //}

            //Console.WriteLine("String without duplicates: " + b);
         

    }

}
}
