using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.API.Entities
{
    public class LeaveConsumed
    {
        public int LeaveConsumedId { get; set; }

        public int EmployeeId { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public decimal NumberOfDays { get; set; }

        public string? LeaveStatus { get; set; }

        public string? Comments { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; }

        public int? ApprovedBy { get; set; }

    }
}
