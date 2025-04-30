using NestSecure.ComplaintService.Core;
using NestSecure.MaintenanceService.Core;
using NestSecure.MaintenanceService.Entities;

namespace NestSecure.MaintenanceService.Repositories
{
    public class MaintenanceRepo : Repository<Maintenance>, IMaintenanceRepo
    {
        public MaintenanceRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
