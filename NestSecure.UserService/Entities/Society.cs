namespace NestSecure.UserService.Entities
{
    public class Society : BaseEntity
    {
        public int SocietyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
