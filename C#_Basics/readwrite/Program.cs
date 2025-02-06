using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readwrite
{
    internal class Program
    {
        int num1, num2, result;
        public int pnum1
        {
            set
            {

                num1 = value;
            }

        }
        public int pnum2
        {
            set
            {
                num2 = value;
            }
        }
        public int presult
        {
            get
            {
                return result;            }

        }
        public void add()
        {
            result = num1 + num2;

        }


        class readwrite
        {
            int numb1, numb2, result;
            public int snum
            {
                set { numb1 = value; }
            }
            public int snumb2
            {
                set { numb2 = value; }
                get { return result; }
            }

           

            public void mul()
            {
                result = numb1 * numb2;

            }
            class scene
            {
                static void Main(string[] args)
                {
                    Program s = new Program();
                    readwrite s2 = new readwrite();
                    s2.numb1 = Convert.ToInt32(Console.ReadLine());
                    s2.numb2 = Convert.ToInt32( Console.ReadLine());
                    s.pnum1 = Convert.ToInt32(Console.ReadLine());
                    s.pnum2 = Convert.ToInt32(Console.ReadLine());
                    s.add();
                    s2.mul();
                    Console.WriteLine("the multiplication of number" + s2.result);
                    Console.WriteLine("the addition of two number" + s.result);
                    


                }
            }
        }
    }
}




