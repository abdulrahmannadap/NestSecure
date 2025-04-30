using NestSecure.ComplaintService.Core;
using NestSecure.ComplaintService.Entities;
using NestSecure.ComplaintService.Repositories;

namespace NestSecure.AuthService.Repositories
{
    public class ComplaintRepo : Repository<Complaint>, IComplaintRepo
    {
        public ComplaintRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
