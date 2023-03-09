using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class AssignmentPerson
    {
        public int AssignmentId { get; set; }
        public int PersonId { get; set; }
        public int PersonCode { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public int SupplierId { get; set; }

        public virtual Assignment Assignment { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
