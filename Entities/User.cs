using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.API.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(20)]
        public string UserType { get; set; } = string.Empty;

        [Required, StringLength(30)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(30)]
        public string? LastName { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        // 🔁 Relationships
        public ICollection<LeaveConsumed>? LeavesRequested { get; set; }
        public ICollection<LeaveConsumed>? LeavesApproved { get; set; }
    }
}
