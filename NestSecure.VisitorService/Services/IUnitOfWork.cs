using NestSecure.VisitorService.Core;

namespace NestSecure.VisitorService.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IVisitorRepo VisitorRepo { get; }
        Task<int> CompleteAsync();
    }
}
