namespace NestSecure.UserService.Entities
{
    public class HouseOwner : BaseEntity
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FlatNumber { get; set; }
        public string PasswordHash { get; set; }
        public int SocietyId { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedDate { get; set; }

        public Society Society { get; set; }
    }
}
