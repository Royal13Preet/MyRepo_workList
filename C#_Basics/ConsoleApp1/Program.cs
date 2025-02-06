using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public interface nokia
    {
        void sms();
       
    }

    public interface nokia2
    {
        void sms2();

    }
        
}

public class newnokia : Program.nokia, Program.nokia2
{
    public void sms()
    {
        Console.WriteLine("we can send sms");
    }
    public void sms2()
    {
        Console.WriteLine("we can use wifi");
    }
    public static void Main(string[] args)
    {
        newnokia n = new newnokia();
        n.sms();
        n.sms2();

    }
}
        
 

