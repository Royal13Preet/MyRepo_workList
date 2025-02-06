class product 
{
    public int a = 10;
    public int b = 20;
    public string a = 'preet'


    
    public async Task<int> Method1()
    {
        Console.WriteLine(a);
        await.Sleep(1000);
    }

    public void Method2()
    {
        Method1();
        Console.WriteLine(a);


    }

}
using system;
{
    class program
{
    public int a;
    public int b;

    public async void Method1()
    {
        a = 10;
        b = 20;
        await Task.Sleep(2000);
        Console.WriteLine(a);
        
    }

    public void Method2()
    {
        Method1();
    }
}
}

class Program : product
{
    product product1 = new product();
    product1.Method1();
   
}

public delegate string Method1();

public void