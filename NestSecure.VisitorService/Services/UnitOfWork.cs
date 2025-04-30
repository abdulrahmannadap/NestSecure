using NestSecure.VisitorService.Core;

namespace NestSecure.VisitorService.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IVisitorRepo VisitorRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext context, IVisitorRepo visitorRepo)
        {
            _context = context;
            VisitorRepo = visitorRepo;
        }

        //public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        //{
        //    return new Repository<TEntity>(_context);
        //}

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
