namespace ConsoleApp1;

public class MyHouse : House
{
    public override void CloseDoor()
    {
        GetDoor().OpenDoor(); 
    }

    public override void OpenDoor()
    {
        GetDoor().CloseDoor();
    }
}