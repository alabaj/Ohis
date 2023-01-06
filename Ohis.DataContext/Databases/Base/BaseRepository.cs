using SQLite;

namespace Ohis.DataContext.Databases.Base
{
    public abstract class BaseRepository<T>
        where T : new()
    {
        protected SQLiteAsyncConnection _databaseConnection;

        protected async Task Init()
        {
            if (_databaseConnection != null)
            {
                return;
            }

            _databaseConnection = new SQLiteAsyncConnection(Constants.DatabasePath(), Constants.Flags);
            await _databaseConnection.CreateTableAsync<T>();
        }
    }
}
