using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject
{
    internal class Program
    {
        int length = 6;
        int breadth = 8;
        public void rect()
        {

            int rect = length * breadth;
            Console.WriteLine(rect);

        }
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.rect();

        }
    }
}
