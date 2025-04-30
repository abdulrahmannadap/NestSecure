using NestSecure.AuthService.Core;
using NestSecure.AuthService.Entities;

namespace NestSecure.AuthService.Repositories
{
    public class RoleRepo : Repository<Role>, IRoleRepo
    {
        public RoleRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
