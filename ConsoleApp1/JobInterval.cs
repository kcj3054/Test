using System.Timers;
using Timer = System.Timers.Timer;

namespace ConsoleApp1;

//특정 주기마다 이벤트가 발생하도록.. 
public class JobInterval
{
    private Queue<Timer> _timers = new();

    public void Charge(double interval, ElapsedEventHandler callbackFunc)
    {
        var timer = new Timer();
        timer.Interval = interval;
        timer.Elapsed += callbackFunc;
        timer.Start();

        _timers.Enqueue(timer);
    }
    
    public void Destroy()
    {
        foreach (var timer in _timers)
        {
            timer.Stop();
        }
        _timers.Clear();
    }
}