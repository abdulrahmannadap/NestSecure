using NestSecure.ComplaintService.Core;

namespace NestSecure.ComplaintService.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IComplaintRepo ComplaintRepo { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IComplaintRepo complaintRepo)
        {
            _context = context;
            ComplaintRepo = complaintRepo;

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
