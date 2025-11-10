using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.API.Entities
{
    [Table("LeavesConsumed")]
    public class LeaveConsumed
    {
        [Key]
        public int LeaveConsumedId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("LeaveType")]
        public int LeaveTypeId { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal NumberOfDays { get; set; }

        [Required, StringLength(30)]
        public string LeaveStatus { get; set; } = "Pending";

        public string? Comments { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("ApprovedByUser")]
        public int? ApprovedBy { get; set; }

        // 🔁 Navigation Properties
        public User? Employee { get; set; }

        public LeaveType? LeaveType { get; set; }

        public User? ApprovedByUser { get; set; }
    }
}
