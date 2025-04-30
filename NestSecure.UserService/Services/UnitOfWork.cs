using NestSecure.UserService.Core;

namespace NestSecure.UserService.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IHouseOwnerRepo HouseOwnerRepo { get; private set; }
        public ISecretaryRepo SecretaryRepo { get; private set; }
        public ISecurityGuardRepo SecurityGuardRepo { get; private set; }
        public ISocietyRepo SocietyRepo { get; private set; }

        public UnitOfWork(ApplicationDbContext context,
                          IHouseOwnerRepo houseOwnerRepo,
                          ISecretaryRepo secretaryRepo,
                          ISecurityGuardRepo securityGuardRepo,
                          ISocietyRepo societyRepo)
        {
            _context = context;
            HouseOwnerRepo = houseOwnerRepo;
            SecretaryRepo = secretaryRepo;
            SecurityGuardRepo = securityGuardRepo;
            SocietyRepo = societyRepo;
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
