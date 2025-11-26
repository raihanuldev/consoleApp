using System.Runtime.Intrinsics.X86;

namespace ConsoleApp;
class Bag
{
    public string Company;
    public string Color;
    public Bag(string company,string color)
    {
        Company = company;
        Color = color;
    }
    public Bag()
    {
        Company = "NULL";
        Color = "NULL ";
    }

}

class LifeStyle : Bag
{
    string tshrrtBrand ="XYS";
    
}

class Practice
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Practice Day!");
        Bag b1 = new Bag();
        Bag b2 = new Bag("HP","Red");

        // this example showcase class constrctor, Method OVerloading.
        Console.WriteLine("The Bag Company of b1=> "+b1.Company +" and the color of "+b1.Color);
        Console.WriteLine("The Bag Company of b2=> "+b2.Company +" and the color of "+b2.Color);

        // this example showcase of Inheritance 
        LifeStyle raihan = new LifeStyle();
        raihan.Color = "pink";
        Console.WriteLine("bag color of raihan alom is=> "+ raihan.Color);
    }
}