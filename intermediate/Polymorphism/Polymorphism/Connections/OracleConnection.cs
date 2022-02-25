public class OracleConnection : DbConnection
{
    private string _connectionString;

    public OracleConnection(string connectionString) : base(connectionString)
    {
        _connectionString = connectionString;
    }
    public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
    {
        _connectionString = connectionString;
    }

    public override void OpenConnection()
    {
        Console.WriteLine($"Open Oracle connection with { _connectionString }");
    }
    public override void CloseConnection()
    {
        Console.WriteLine("Close Oracle Connection");
    }
}