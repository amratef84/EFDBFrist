using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class PortOfEntry
    {
        public PortOfEntry()
        {
            SeizureProcesses = new HashSet<SeizureProcess>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<SeizureProcess> SeizureProcesses { get; set; }
    }
}
