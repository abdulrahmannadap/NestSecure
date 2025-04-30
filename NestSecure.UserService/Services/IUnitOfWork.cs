using NestSecure.UserService.Core;

namespace NestSecure.UserService.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IHouseOwnerRepo HouseOwnerRepo { get; }
        ISecretaryRepo SecretaryRepo { get; }
        ISecurityGuardRepo SecurityGuardRepo { get; }
        ISocietyRepo SocietyRepo { get; }
        Task<int> CompleteAsync();
    }
}
