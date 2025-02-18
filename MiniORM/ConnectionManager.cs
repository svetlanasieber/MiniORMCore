namespace MiniORM;

internal class ConnectionManager : IDisposable
{
    private readonly DatabaseConnection _connection;
    public ConnectionManager(DatabaseConnection connection)
    {
        this._connection = connection;

        this._connection.Open();
    }

    public void Dispose()
    {
        this._connection.Close();
    }
}
