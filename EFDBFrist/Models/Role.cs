using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Role: BaseEntityName<Guid>
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
            Users = new HashSet<User>();
        }

        public bool Status { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
