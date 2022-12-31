namespace Ohis.DataContext.Databases.Base
{
    public interface IWriteRepository<T>
        where T : new()
    {
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
