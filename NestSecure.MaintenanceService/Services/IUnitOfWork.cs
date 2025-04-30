using NestSecure.MaintenanceService.Core;

namespace NestSecure.MaintenanceService.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IMaintenanceRepo MaintenanceRepo { get; }

        Task<int> CompleteAsync();
    }
}
