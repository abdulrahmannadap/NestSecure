using NestSecure.UserService.Entities;

namespace NestSecure.MaintenanceService.Entities
{
    public class Maintenance : BaseEntity
    {
        public int MaintenanceId { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public int OwnerId { get; set; }
        public string Status { get; set; }  // Paid, Unpaid

        public HouseOwner Owner { get; set; }
    }

}
