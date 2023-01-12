namespace ConsoleApp1;

public delegate bool CompareDelegate(object arg1, object arg2); // object 인자가 2개 

public class SortObject
{
    private object[] things;
    
    public SortObject(object[] things)
    {
        this.things = things;
    }

    public void Sort(CompareDelegate compareDelegate)
    {
        object tmp;

        for (int i = 0; i < things.Length; ++i)
        {
            int lowPos = i;

            for (int j = i + 1; j < things.Length; ++i)
            {
                if (compareDelegate(things[j], things[i]))
                {
                    lowPos = j;
                }
            }

            tmp = things[lowPos];
            things[lowPos] = things[i];
            things[i] = tmp;
        }
    }
}

public class Sort
{
    static bool AscSortByName(object arg1, object arg2)
    {
        Person person1 = arg1 as Person;
        Person person2 = arg2 as Person;

        return person1.name.CompareTo(person2.name) < 0;
    }
}

public class Person
{
    public string name;
}