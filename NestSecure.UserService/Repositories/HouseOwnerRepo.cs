using NestSecure.UserService.Core;
using NestSecure.UserService.Entities;

namespace NestSecure.UserService.Repositories
{
    public class HouseOwnerRepo : Repository<HouseOwner>, IHouseOwnerRepo
    {
        public HouseOwnerRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
