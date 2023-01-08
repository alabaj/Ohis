using AutoMapper;

namespace Ohis.DataContext.Databases.Base
{
    public abstract class BaseRepository
    {
        private protected readonly IMapper _mapper;
        private protected readonly AppDbContext _context;

        protected BaseRepository(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
    }
}
