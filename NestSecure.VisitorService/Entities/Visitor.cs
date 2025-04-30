using NestSecure.UserService.Entities;

namespace NestSecure.VisitorService.Entities
{
    public class Visitor : BaseEntity
    {
        public int VisitorId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime VisitTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public string Purpose { get; set; }
        public string FlatNumber { get; set; }
        public bool IsPreApproved { get; set; }
        public int? ApprovedByOwnerId { get; set; }
        public int GuardId { get; set; }
        public int SocietyId { get; set; }

        public HouseOwner ApprovedByOwner { get; set; }
        public SecurityGuard Guard { get; set; }
        public Society Society { get; set; }
    }
}
