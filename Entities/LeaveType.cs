using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.API.Entities
{
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }

        public string? LeaveTypeName { get; set; }

        public decimal DaysPerMonth { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
