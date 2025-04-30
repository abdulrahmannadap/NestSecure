using NestSecure.AuthService.Core;
using NestSecure.AuthService.Entities;

namespace NestSecure.AuthService.Repositories
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        public UserRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
