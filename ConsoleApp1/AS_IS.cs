namespace ConsoleApp1;

public class AS_IS
{
    public static void Init()
    {
        Computer pc = new();
        NoteBook noteBook = pc as NoteBook;

        if (noteBook != null)
        {
            Console.WriteLine("Asdfasdfasdf");
        }
    }
}

public class Computer
{
    
}

public class NoteBook : Computer
{
    
}