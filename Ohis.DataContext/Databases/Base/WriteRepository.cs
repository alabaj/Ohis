namespace Ohis.DataContext.Databases.Base
{
    public class WriteRepository<T> : BaseRepository<T>, IWriteRepository<T>
        where T : new()
    {
        public async Task<int> Add(T entity)
        {
            await Init();

            return await _databaseConnection.InsertAsync(entity);
        }

        public async Task<int> Update(T entity)
        {
            await Init();

            return await _databaseConnection.UpdateAsync(entity);
        }

        public async Task<int> Delete(T entity)
        {
            await Init();

            return await _databaseConnection.DeleteAsync(entity);
        }
    }
}
