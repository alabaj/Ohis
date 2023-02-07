using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ohis.DataContext.Databases.Base
{
    public class ReadRepository<TEntity, TModel> : BaseRepository, IReadRepository<TEntity, TModel>
        where TEntity : class
    {
        public ReadRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
        {
        }

        public async Task<TModel> FindByProperty(Expression<Func<TEntity, bool>> expression)
        {
            var result = await _context.Set<TEntity>().AsNoTracking().Where(expression).FirstAsync();

            return _mapper.Map<TModel>(result);
        }

        public async Task<List<TModel>> GetAll()
        {
            var result = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            return _mapper.Map<List<TModel>>(result);
        }

        public async Task<List<TModel>> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            var result = await _context.Set<TEntity>().AsNoTracking().Where(expression).ToListAsync();

            return _mapper.Map<List<TModel>>(result);
        }
    }
}
