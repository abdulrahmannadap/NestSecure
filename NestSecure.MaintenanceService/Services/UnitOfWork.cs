using NestSecure.ComplaintService.Core;
using NestSecure.MaintenanceService.Core;

namespace NestSecure.MaintenanceService.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IMaintenanceRepo MaintenanceRepo { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IMaintenanceRepo maintenanceRepo)
        {
            _context = context;
            MaintenanceRepo = maintenanceRepo;

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
