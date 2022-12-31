using System.Linq.Expressions;

namespace Ohis.DataContext.Databases.Base
{
    public interface IReadRepository<T>
        where T : new()
    {
        Task<T> FindByProperty(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
    }
}
