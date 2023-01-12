namespace ConsoleApp1;
public interface Door
{
    public void OpenDoor();
    public void CloseDoor();
}

public class MyDoor : Door
{ 
    public void OpenDoor()
    {
        Console.WriteLine("MyDoor - Open");
    }

    public void CloseDoor()
    {
        Console.WriteLine("MyDoor - Close");
    }
}