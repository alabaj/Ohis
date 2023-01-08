namespace Ohis.DataContext.Databases.Base
{
    public interface IWriteRepository<TEntity, TModel>
        where TEntity : class
    {
        TModel Add(TModel model);
        TModel Update(TModel model);
        bool Delete(TModel model);
    }
}
