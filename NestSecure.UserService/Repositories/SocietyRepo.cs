using NestSecure.UserService.Core;
using NestSecure.UserService.Entities;

namespace NestSecure.UserService.Repositories
{
    public class SocietyRepo : Repository<Society>, ISocietyRepo
    {
        public SocietyRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
