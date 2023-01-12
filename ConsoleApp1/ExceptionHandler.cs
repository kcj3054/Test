using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1;

public static class ExceptionHandler
{
    public static void Init()
    {
        
        var t1 = Task.Factory.StartNew(
            () =>
            {
                throw new InvalidOperationException("can't do this") { Source = "t" };
            });

        var t2 = Task.Factory.StartNew(
            () =>
            {
                throw new AccessViolationException("can't access this!!") { Source = "t2" };
            });
        try
        {
            Task.WaitAll(t1, t2);
        }
        // AggregateException? 
        //invalid operation을 미리 다루어야한다.. 
        catch (AggregateException ae)
        {
            ae.Handle(
                e =>
                {
                    if (e is InvalidOperationException)
                    {
                        Console.WriteLine("Invalid op!");
                        return true;
                    }
                    return false;
                });
            
            // foreach (var e in ae.InnerExceptions)
            // {
            //     Console.WriteLine($"Exception {e.GetType()} from {e.Source}");
            // }
        }

    }
}