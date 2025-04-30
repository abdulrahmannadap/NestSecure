using NestSecure.UserService.Core;
using NestSecure.UserService.Entities;

namespace NestSecure.UserService.Repositories
{
    public class SecretaryRepo : Repository<Secretary>, ISecretaryRepo
    {
        public SecretaryRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
