using System;
using System.Xml.Schema;

class area
{
    
    int length = Convert.ToInt32(Console.ReadLine());
    int breadth = Convert.ToInt32(Console.ReadLine());

    void rectangle()
    {
        int areaofrecta = length * breadth;
        Console.WriteLine(areaofrecta);
    }

    void triangle()
    {
        double areaoftriangle = 1.0 / 2.0 * (length * breadth);
        Console.WriteLine(areaoftriangle);
    }
    void circle()

    {
        Console.Write("enter a radius of circle");
        int r = Convert.ToInt32(Console.ReadLine());
        double areaofcircle = 3.14 * r * r;
        Console.WriteLine(areaofcircle);
    }
    public static void Main(string[] args)
    {
        area rectangle1 = new area();

        rectangle1.rectangle();
        rectangle1.triangle();
        rectangle1.circle();
        Console.ReadLine();
        
        
    }

}
