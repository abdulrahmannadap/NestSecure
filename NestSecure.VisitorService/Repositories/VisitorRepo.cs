using NestSecure.VisitorService.Core;
using NestSecure.VisitorService.Entities;

namespace NestSecure.VisitorService.Repositories
{
    public class VisitorRepo : Repository<Visitor>, IVisitorRepo
    {
        public VisitorRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
