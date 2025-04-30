using NestSecure.UserService.Core;
using NestSecure.UserService.Entities;

namespace NestSecure.UserService.Repositories
{
    public class SecurityGuardRepo : Repository<SecurityGuard>, ISecurityGuardRepo
    {
        public SecurityGuardRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
