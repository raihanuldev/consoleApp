namespace ConsoleApp;


interface system
{
    void trunOn();
}
interface ISoftwares
{
    void loadApp();
}
class Laptop : system,ISoftwares
{
    public void trunOn()
    {
        Console.WriteLine("Laptop are Opeening... wait for it");
    }
    public void loadApp()
    {
        Console.WriteLine("System App File Are Loading.....");
    }
}

class InterfaceMain
{
    static void Main(string[] args)
    {
        Laptop hp = new Laptop();
        hp.trunOn();
        hp.loadApp();
    }
}