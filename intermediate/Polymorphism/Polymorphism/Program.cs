class Program
{
    static void Main()
    {
        DbCommand dbsql = new DbCommand(new SqlConnection("http://sql.connection:1231"));
        dbsql.ExecuteWithTimeOut();
        dbsql.Execute();
        DbCommand dbsqlTO = new DbCommand(new SqlConnection("http://sql.connection:1231", TimeSpan.FromMilliseconds(0.1)));
        dbsqlTO.ExecuteWithTimeOut();
        dbsqlTO.Execute();
        DbCommand dboracle = new DbCommand(new OracleConnection("http://oracle.connections:1234"));
        dboracle.ExecuteWithTimeOut();
        dboracle.Execute();
        DbCommand dboracleTO = new DbCommand(new OracleConnection("http://oracle.connections:1234",TimeSpan.FromMilliseconds(0.1)));
        dboracleTO.ExecuteWithTimeOut();
        dboracleTO.Execute();
    }
}
