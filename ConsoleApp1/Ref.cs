namespace ConsoleApp1;
public class Ref
{
    //예제를 위해서 Init으로 명시. 
    public void Init()
    {
        Point pt1 = null;
        
        
    }

    public static void Change1(Point pt)
    {
        pt = new();

        pt.X = 6;
        pt.Y = 7;
    }

    public static void Change2(ref Point pt) // ref를 이용한 참조에 의한 호출
    {
        pt = new();

        pt.X = 7;
        pt.Y = 8;
    }
}

public struct Vector
{
    public int x;
    public int y;
}

public class Point
{
    public int X;
    public int Y;
}