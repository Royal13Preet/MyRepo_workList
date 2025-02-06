using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vary = new int[] { 78, 8, 6, 4, 6, 663, 24, 654 };
            
            for (int i = 0; i < vary.Length; i++)
            {
                                        //8-1 = 7
                for (int j = 0; j < vary.Length-1; j++)
                {
                    if(vary[j] > vary[j+1])
                    {
                        int temp = vary[j + 1];
                        vary[j + 1] = vary[j];
                        vary[j] = temp;                                                      //0 1  2 3 4  5  6   7
                    }
    
                }
            }                                                                                   
            foreach(int i in vary)
            {
                Console.WriteLine(i);
            }  
        }
    }
}
// i = 0, j = 0 vary[0] > vary[0 + 1]-- > 78 > 8-- > true, temp = 8 | vary[1] = 78 | vary[0] = 8, { 8,78,6,4,6,663,24,654}
//i = 0, j = 1 vary[1] > vary[1+1] --> 78 > 6 -->true, temp = 6 | vary[2] = 78 | vary[1] = 6, {8,6,78,4,6,663,24,654}
//i = 0, j = 2 vary[2] > vary[2+1] --> 78 > 4 -->true, temp = 4 | vary[3] = 78 | vary[2] = 4, {8,6,4,78,6,663,24,654}
//i = 0, j = 3 vary[3] > vary[3+1] --> 78 > 6 -->true, temp = 6 | vary[4] = 78 | vary[3] = 6, {8,6,4,6,78,663,24,654}
//i = 0, j = 4 vary[4] > vary[4+1] --> 78 > 663 ->false                                       {8,6,4,6,78,663,24,654}
//i = 0, j = 5 vary[5] > vary[5+1] --> 663 > 24 ->true, temp = 24| vary[6] = 663|vary[5] = 24,{8,6,4,6,78,24,663,654}
//i = 0, j = 6 vary[6] > vary[6+1] --> 663 > 654 ->true,temp = 654|vary[7] = 663|vary[6]= 654,{8,6,4,6,78,24,654,663}
//i = 0, j = 7 false come out of the loop
//i = 1, j = 0 vary[0] > vary[0+1] --> 8 > 6 --> true, temp = 6 | vary[1] = 8 | vary[0] = 6,  {6,8,4,6,78,24,654,663}
//i = 1, j = 1 vary[1] > vary[1+1] --> 8 > 4 --> true, temp = 4 | vary[2] = 8 | vary[1] = 4,  {6,4,8,6,78,24,654,663}
//i = 1, j = 2 vary[2] > vary[2+1] --> 8 > 6 --> true, temp = 6 | vary[3] = 8 | vary[2] = 6,  {6,4,6,8,78,24,654,663}
//i = 1, j = 3 vary[3] > vary[3+1] --> 8 > 78 --> false
//i = 1, j = 4 vary[4] > vary[4+1] --> 78 > 24 ->true, temp = 24| vary[5] =78 | vary[4] = 24, {6,4,6,8,24,78,654,663}
//i = 1, j = 5 vary[5] > vary[5+1] --> 78 > 654 -->false
//i = 1, j = 6 vary[6] > vary[6+1] --> 654 > 663 --> false
//i = 1, j = 7 false come out of the loop
//i = 2, j = 0 vary[0] > vary[0+1] --> 6 > 4 -->true, temp = 4 | vary[1] = 6 | vary[0] = 4 ,  {4,6,6,8,24,78,654,663}
//i = 2, j = 1 vary[1] > vary[1+1] --> 6 > 6 --> false
//i = 2, j = 2 vary[2] > vary[2+1] --> 6 > 8 -->false
//i = 2, j = 3 vary[3] > vary[3+1] --> 8 > 24 --> false
//i = 2, j = 4 vary[4] > vary[4+1] --> 24 > 78 --> false
//i = 2, j = 5 vary[5] > vary[5+1] --> 78 > 654 --> false
//i = 2, j = 6 vary[6] > vary[6+1] --> 654 > 663 --> false
//i = 2, j = 7 false come out of the loop
//i = 3, j = 0 vary[0] > vary[0+1] --> 4 > 6 --> false
//i = 3, j = 1 vary[1] > vary[1+1] --> 6 > 6 --> false
//i = 3, j = 2 vary[2] > vary[2+1] --> 6 > 8 --> false
//i = 3, j = 3 vary[3] > vary[3+1] --> 8 > 24 --> false
//i = 3, j = 4 vary[4] > vary[4+1] --> 24 > 78 --> false
//i = 3, j = 5 vary[5] > vary[5+1] --> 78 > 654 --> false
//i = 3, j = 6 vary[6] > vary[6+1] --> 654 > 663 --> false
//i = 3, j = 7 false come out of the loop
//i = 4, j = 0 vary[0] > vary[0+1] --> 4 > 6 --> false
//i = 4, j = 1 vary[1] > vary[1+1] --> 6 > 6 --> false
//i = 4, j = 2 vary[2] > vary[2+1] --> 6 > 8 --> false
//i = 4, j = 3 vary[3] > vary[3+1] --> 8 > 24 --> false
//i = 4, j = 4 vary[4] > vary[4+1] --> 24 > 78 --> false
//i = 4, j = 5 vary[5] > vary[5+1] --> 78 > 654 --> false
//i = 4, j = 6 vary[6] > vary[6+1] --> 654 > 663 --> false
//i = 4, j = 7 false come out of the loop