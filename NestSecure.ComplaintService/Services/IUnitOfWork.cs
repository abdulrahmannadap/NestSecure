using NestSecure.ComplaintService.Core;

namespace NestSecure.ComplaintService.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IComplaintRepo ComplaintRepo { get; }

        Task<int> CompleteAsync();
    }
}
