using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonelemnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 3, 2, 1 };

            int[] a2 = new int[] { 1, 2, 3 };

            int[] a3 = new int[] { 1, 2, 3, 4 };

            int[] a4 = new int[a1.Length];
            int printedCount = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        for (int k = 0; k < a3.Length; k++)
                        {
                            if (a1[i] == a3[k])
                            {
                                bool alreadyPresented = false;
                                for (int l = 0; l < printedCount; l++)
                                {
                                    if ((a4[l] == a2[j]))
                                    {
                                        alreadyPresented = true;
                                        break;
                                    }
                                }


                                if (!alreadyPresented)
                                {
                                    Console.WriteLine(a1[i]);
                                    a4[printedCount++] = a1[i];
                                    printedCount++;

                                }
                                break;
                            }
                        }
                        break;
                    }

                }
            }



        }
    }
}


