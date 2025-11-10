using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.API.Entities
{
    [Table("LeaveType")]
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }

        [Required, StringLength(50)]
        public string LeaveTypeName { get; set; } = string.Empty; // e.g. "Sick Leave", "Casual Leave"

        [Column(TypeName = "decimal(4,2)")]
        public decimal DaysPerMonth { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // 🔁 Relationship
        public ICollection<LeaveConsumed>? LeavesConsumed { get; set; }
    }
}
