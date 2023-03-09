using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Permission
    {
        public int Id { get; set; }
        public bool Add { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Print { get; set; }
        public bool Show { get; set; }
        public bool Other { get; set; }
        public bool Search { get; set; }
        public int ParentId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
