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

        private void SaveChanges()
        {
            _context.SaveChanges();
        }

        public TModel Add(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Add(entity);
            SaveChanges();

			return model;
        }

        public TModel Update(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Update(entity);
            SaveChanges();

			return model;
        }

        public bool Delete(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _context.Set<TEntity>().Remove(entity);
			SaveChanges();

			return true;
        }
    }
}
