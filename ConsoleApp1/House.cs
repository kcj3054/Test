namespace ConsoleApp1;

public abstract  class House
{
    private String roof = "House roof";
    private String wall = "House wall";
    private Door door;

    public void setDoor(Door door)
    {
        this.door = door;
    }

    public Door GetDoor()
    {
        return door;
    }

    public virtual void OpenDoor()
    {
        Console.WriteLine("Basic door opend");
    }

    public virtual void CloseDoor()
    {
        Console.WriteLine("Basic door closed");
    }
}