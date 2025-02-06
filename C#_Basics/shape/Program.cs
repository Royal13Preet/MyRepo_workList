using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{

    internal class insertion

    {

        static void Main(string[] args)
        {
            int[] inser = new int[5] { 4, 43, 88, 11, 76 };
            for (int i = 1; i < inser.Length; i++)
            {
                int key = inser[i];
                int j = i - 1;
                
                while (j >= 0 && inser[j] > key)
                {
                    inser[j + 1] = inser[j];
                    j = j - 1;
                }
                inser[j + 1] = key;
// i = 1  key = 43, j = 0 (true && false) --> false  inser[0+1] = 43 { 4, 43, 88, 11, 76}
// i = 2  key = 88, j = 1 (true && false) --> false  inser[1+1] = 88 { 4, 43, 88, 11, 76} 
// i = 3  key = 11, j = 2 (true && true) --> true  inser[3] = 88, j = 2-1 = 1
                   // j = 1 (true && true) -> true inser[2] = 43, j = 1-1 = 0
                   // j = 0 (true && false) --> false inser[1] = 11  {4,11,43,88,76}
// i = 4 key = 76 j = 3 (true && true) --> true inser[4] = 88; j = 3-1 =2
                   // j = 2 (true && false) -> false inser[3] = 76  {4,11,43,76,88}
// i = 5 false
            }
            foreach (int i in inser) { 
                Console.WriteLine(i);
            
            }


        }
    }
}