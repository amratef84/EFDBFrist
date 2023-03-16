using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class AssignmentPerson: BaseLessKey<Guid>
    {
        public int AssignmentId { get; set; }
        public int PersonId { get; set; }
        public int PersonCode { get; set; }
        public bool? IsDeleted { get; set; }
        public int SupplierId { get; set; }

        public virtual Assignment Assignment { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
