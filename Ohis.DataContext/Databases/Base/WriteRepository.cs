namespace Ohis.DataContext.Databases.Base
{
    public class WriteRepository<T> : BaseRepository<T>, IWriteRepository<T>
        where T : new()
    {
        public async Task<int> Add(T entity)
        {
            await Init();

            return await Database.InsertAsync(entity);
        }

        public async Task<int> Update(T entity)
        {
            await Init();

            return await Database.UpdateAsync(entity);
        }

        public async Task<int> Delete(T entity)
        {
            await Init();

            return await Database.DeleteAsync(entity);
        }
    }
}
