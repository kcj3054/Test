using System.Net;

namespace ConsoleApp1;

public class MutexExemple
{
    public BankAccount ba = new ();
    public List<Task> tasks = new ();
    
    public Mutex _mutex = new();
    public void Init()
    {
        for (int i = 0; i < 10; ++i)
        {
            tasks.Add(Task.Factory.StartNew(
                () =>
                {
                    //????
                    // bool haveLock = _mutex.WaitAll();
                }));
        }
    }
}

public class BankAccount
{
    private object _padlock = new();
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        lock (_padlock)
        {
            Balance += amount;
        }
    }

    public void Withdraw(int aomount)
    {
        lock (_padlock)
        {
            Balance -= aomount;
        }
    }
}