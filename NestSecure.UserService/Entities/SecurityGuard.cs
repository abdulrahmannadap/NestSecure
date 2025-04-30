namespace NestSecure.UserService.Entities
{
    public class SecurityGuard : BaseEntity
    {
        public int GuardId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ShiftTime { get; set; }
        public string PasswordHash { get; set; }
        public int SocietyId { get; set; }

        public Society Society { get; set; }
    }
}
