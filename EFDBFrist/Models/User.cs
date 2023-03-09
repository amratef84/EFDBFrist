using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class User
    {
        public User()
        {
            SeizureProcesses = new HashSet<SeizureProcess>();
        }

        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }
        public int Type { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<SeizureProcess> SeizureProcesses { get; set; }
    }
}
