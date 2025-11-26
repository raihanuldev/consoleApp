namespace ConsoleApp;


class Access()
{
     public virtual void Open()
    {
        Console.WriteLine("This is Books are Soon Open loading.....");
    }
}
class Books : Access
{
    public string bookName;
    public override void Open()
    {
        base.Open();
        Console.WriteLine($"{bookName} are Opened..... Enjoy");
    }
    public Books(string name)
    {
        bookName = name;
    }
   public Books()
    {
        bookName = "Not called are BookName";
    }
}





class Polymor
{
    static void Main(string[] args)
    {
        Books physic = new Books("Physics");
        Books chemistry = new Books("Chemisty");
        physic.Open();
        chemistry.Open();

        
        // Class1 class1 = new Class1();
        // Class2 class2 = new Class2();
        // class2.Get1();

    }
}