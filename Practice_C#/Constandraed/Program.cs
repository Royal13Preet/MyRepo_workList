using System;

namespace Constandraed
{
    public class Test
    {
        readonly int read = 10; // Read-only field, can be assigned here or in the constructor
        const int cons = 10;   // Constant field, must be assigned at declaration

        public Test()
        {
            read = 100; // Allowed, as this is a constructor
            // cons = 100; // Error: Cannot assign to a constant field
        }

        public void Check()
        {
            Console.WriteLine("Read only : {0}", read);
            Console.WriteLine("Const : {0}", cons);
        }

        public static void Main(string[] args)
        {
            Test test = new Test(); // Create an instance of the Test class
            test.Check();           // Call the instance method
        }
    }
}
