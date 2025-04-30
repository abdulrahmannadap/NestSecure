using NestSecure.AuthService.Entities;

namespace NestSecure.AuthService.Core
{
    public interface IUserRepo : IRepository<User>
    {
    }
}
