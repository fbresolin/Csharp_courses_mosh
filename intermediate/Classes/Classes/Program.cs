class Program
{
    static void Main()
    {
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Stop();
        stopwatch1.Start();
        for (int i = 0; i < 1100000000; i++)
        {
            int a = 1;
        }
        TimeSpan? timespan = stopwatch1.Stop();
        Console.WriteLine($"The timespan of the stopwatch is { timespan }");
    }
}
public class Stopwatch
{
    // This class simulates a stopwatch
    private DateTime? _StartTime;
    public Stopwatch()
    {
        _StartTime = null;
    }
    public void Start()
    {
        if (_StartTime == null)
        {
            _StartTime = DateTime.Now;
        }
        else
        {
            throw new InvalidOperationException("Cannot start the same stopwatch two times");
        }
    }
    public TimeSpan? Stop()
    {
        if (_StartTime != null)
        {
            TimeSpan? timespan = (DateTime.Now - this._StartTime);
            this._StartTime = null;
            return timespan;
        }
        return null;
    }
}