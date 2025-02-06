using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userauthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] name = new char[10];
            char[] pass = new char[10];
            char ch;
            int i;
            
            Console.Write("enter a username: ");
            for (int x = 0; x < 8; x++)
            {
                name[x] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("enter a password");
            for(i = 0;i < 8; i++)
            {
                ch = Convert.ToChar(Console.Read());
                pass[i] = ch;
                ch = '*';
                Console.WriteLine("{0}", ch);
            }

            pass[i] = '\0';
            Console.WriteLine("\n Your Password is :");
            for (i = 0; i < 8; i++)
            {
                Console.Write("{0}", pass[i]);
            }
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
