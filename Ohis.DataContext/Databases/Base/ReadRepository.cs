using System.Linq.Expressions;

namespace Ohis.DataContext.Databases.Base
{
    public class ReadRepository<T> : BaseRepository<T>, IReadRepository<T>
        where T : new()
    {
        public async Task<T> FindByProperty(Expression<Func<T, bool>> expression)
        {
            await Init();

            return await Database.Table<T>().Where(expression).FirstAsync();
        }

        public async Task<List<T>> GetAll()
        {
            await Init();

            return await Database.Table<T>().ToListAsync();
        }
    }
}
