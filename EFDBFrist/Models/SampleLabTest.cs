using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class SampleLabTest
    {
        public SampleLabTest()
        {
            SeizureProducts = new HashSet<SeizureProduct>();
        }

        public int Id { get; set; }
        public bool Status { get; set; }
        public int Result { get; set; }
        public string? Notes { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<SeizureProduct> SeizureProducts { get; set; }
    }
}
