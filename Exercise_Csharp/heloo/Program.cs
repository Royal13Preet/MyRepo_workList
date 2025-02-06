using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heloo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            if (System.Console.OpenStandardOutput().BeginWrite(new byte[] { 072, 101,
             108, 108, 111, 032, 087, 111, 114, 108, 100, 0 }, 0,
                12, null, null).AsyncWaitHandle.WaitOne())
            {

            }
            if (System.Console.ReadKey().Modifiers == 0)
            {
            }
        
        }
    }
    
}
