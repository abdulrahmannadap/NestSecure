using NestSecure.AuthService.Core;

namespace NestSecure.AuthService.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUserRepo UserRepo { get; private set; }
        public IRoleRepo RoleRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext context, IUserRepo userRepo, IRoleRepo roleRepo)
        {
            _context = context;
            UserRepo = userRepo;
            RoleRepo = roleRepo;
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
