namespace NestSecure.AuthService.Entities
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        public Role Role { get; set; }
    }
}
