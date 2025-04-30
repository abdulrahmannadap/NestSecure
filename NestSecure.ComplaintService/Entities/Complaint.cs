using NestSecure.UserService.Entities;

namespace NestSecure.ComplaintService.Entities
{
    public class Complaint : BaseEntity
    {
        public int ComplaintId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RaisedByOwnerId { get; set; }
        public int AssignedToSecretaryId { get; set; }
        public string Status { get; set; }  // Open, In Progress, Closed
        public DateTime CreatedDate { get; set; }

        public HouseOwner RaisedByOwner { get; set; }
        public Secretary AssignedToSecretary { get; set; }
    }
}
