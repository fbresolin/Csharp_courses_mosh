using System.Diagnostics;

public abstract class DbConnection
{
    private TimeSpan _timeOut = TimeSpan.FromMilliseconds(50000);
    public DbConnection(string connectionString)
    {
        if (String.IsNullOrEmpty(connectionString))
            throw new ArgumentNullException(nameof(connectionString),"A null argument is passed for the connection string");
    }
    public DbConnection(string connectionString, TimeSpan timeOut)
    {
        if (String.IsNullOrEmpty(connectionString))
            throw new ArgumentNullException(nameof(connectionString), "A null argument is passed for the connection string");
        _timeOut = timeOut;
    }
    public abstract void OpenConnection();
    public abstract void CloseConnection();
    public void OpenConnectionWithTimeOut()
    {
        Stopwatch sw = Stopwatch.StartNew();
        bool DoneWithWork = false;
        while (sw.Elapsed < _timeOut && !DoneWithWork)
        {
            OpenConnection();
            DoneWithWork = true;
        }
        if (DoneWithWork == false)
            throw new TimeoutException();
    }
}
