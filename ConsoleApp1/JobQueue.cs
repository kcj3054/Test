using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1;

public interface IJobQueue
{
    void Push(Action job);
}

public class JobQueue : IJobQueue
{
    private Queue<Action> _jobQueue = new();
    private object _lock = new();
    
    public void Push(Action job)
    {
        
    }

    void Flush()
    {
        while (true)
        {
            Action action = Pop();
        }
    }

    Action Pop()
    {
        lock (_lock)
        {
            //XXXX
            return _jobQueue.Dequeue();
        }
    }
}