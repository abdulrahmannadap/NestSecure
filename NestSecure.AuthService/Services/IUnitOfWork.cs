using NestSecure.AuthService.Core;

namespace NestSecure.AuthService.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IUserRepo UserRepo { get; }
        IRoleRepo RoleRepo { get; }
        Task<int> CompleteAsync();
    }
}
