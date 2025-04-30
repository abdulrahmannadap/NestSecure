namespace NestSecure.Shared.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; } // "Owner", "Guard", etc.
    }
}
