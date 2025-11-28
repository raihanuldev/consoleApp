namespace ConsoleApp;


abstract class Animal
{
    public abstract void AnimalSound();
    public void sleep()
    {
        Console.WriteLine("ZZZZZ");
    }
}
class pig : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The Pig Says: Wee wee");
    }
}


class Abstraction
{
    static void Main(string[] args)
    {
        pig obj = new pig();
        obj.AnimalSound();
        obj.sleep();
        Console.WriteLine("Hello Abstraction");
    }
}