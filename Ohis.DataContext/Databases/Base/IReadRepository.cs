using System.Linq.Expressions;

namespace Ohis.DataContext.Databases.Base
{
    public interface IReadRepository<TEntity, TModel>
        where TEntity : class
    {
        Task<TModel> FindByProperty(Expression<Func<TEntity, bool>> expression);
        Task<List<TModel>> GetAll();
    }
}
