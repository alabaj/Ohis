using AutoMapper;
using AutoMapper.Internal.Mappers;

namespace Ohis.DataContext.Databases.Base
{
    public class WriteRepository<TEntity, TModel> : BaseRepository, IWriteRepository<TEntity, TModel>
        where TEntity : class
    {
        public WriteRepository(IMapper mapper, AppDbContext context) : base(mapper, context)
        {
        }

        public TModel Add(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Add(entity);

            return model;
        }

        public TModel Update(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Update(entity);
            
            return model;
        }

        public bool Delete(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Remove(entity);

            return true;
        }
    }
}
