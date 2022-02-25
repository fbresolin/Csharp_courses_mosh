public class SqlConnection : DbConnection
{
    private string _connectionString;
    public SqlConnection(string connectionString) : base(connectionString)
    {
        _connectionString = connectionString;
    }
    public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
    {
        _connectionString = connectionString;
    }

    public override void OpenConnection()
    {
        Console.WriteLine($"Open Sql connection with { _connectionString }");
    }
    public override void CloseConnection()
    {
        Console.WriteLine($"Close Sql connection with { _connectionString }");
    }
}