// See https://aka.ms/new-console-template for more information
class program
{
    public static void Main(string[] args)
    {
        string txt1 = "Preet";
        string txt2 = "preet";

        string txt3 = "preet";
        string txt4 = "preet";

        string txt5 = "preet";
        string txt6 = "Preet";

        int a = txt1.CompareTo(txt2);
        int b = txt3.CompareTo(txt4);
        int c = txt5.CompareTo(txt6);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }
}
