public class DbCommand
{
    private DbConnection _connection;
    public DbCommand(DbConnection connection)
    {
        if (connection == null)
            throw new ArgumentNullException(connection.GetType().Name);
        _connection = connection;
    }
    public void ExecuteWithTimeOut()
    {
        _connection.OpenConnectionWithTimeOut();
        Console.WriteLine("Pass instructions to the database");
        _connection.CloseConnection();
    }
    public void Execute()
    {
        _connection.OpenConnection();
        Console.WriteLine("Pass instructions to the database");
        _connection.CloseConnection();
    }
}