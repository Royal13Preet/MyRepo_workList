using System;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        // Calling the asynchronous method
      await Method1();

        // Calling the synchronous method
        Method();
    }

    public static async Task Method1()
    {
        Console.WriteLine("Method 1 started");
        await Task.Delay(1000); // Simulates a 1-second delay
        Console.WriteLine("Method 1 completed");
    }

    public static void Method()
    {
        Console.WriteLine("Completed");
    }
}
