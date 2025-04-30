namespace NestSecure.UserService.Entities
{
    public abstract class BaseEntity
    {
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
