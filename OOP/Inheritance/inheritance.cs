namespace ConsoleApp;
class AuthDoor
{
    public void ON()
    {
        Console.WriteLine("The Door is Open Succesfully!");
    }
    public void OFF()
    {
        Console.WriteLine("The Door IS OFF Successfully");
    }
}

class Room : AuthDoor
{
   public string roomNo ="AB101";

}

class InhertianceExample
{
    static void Main(string[] args)
    {
        Room room1 = new Room();
        room1.ON();
        Console.WriteLine(room1.roomNo);
        room1.OFF();
    }
}