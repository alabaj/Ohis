using SQLite;

namespace Ohis.DataContext.Databases.Base
{
    public abstract class BaseRepository<T>
        where T : new()
    {
        protected SQLiteAsyncConnection Database;

        protected async Task Init()
        {
            if (Database is not null)
            {
                return;
            }

            Database = new SQLiteAsyncConnection(Constants.DatabasePath(), Constants.Flags);
            await Database.CreateTableAsync<T>();
        }
    }
}
