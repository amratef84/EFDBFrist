using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            AssignmentPeople = new HashSet<AssignmentPerson>();
            SeizureProcesses = new HashSet<SeizureProcess>();
        }

        public int Id { get; set; }
        public string? ReleaseNo { get; set; }
        public string? Code { get; set; }
        public string? ReasonAssignment { get; set; }
        public DateTime? CreatingDate { get; set; }
        public int ReferenceNo { get; set; }
        public DateTime? UploadDate { get; set; }
        public int Status { get; set; }
        public string? Notes { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public int Duration { get; set; }
        public bool? IsDeleted { get; set; }
        public int AssignmentType { get; set; }

        public virtual ICollection<AssignmentPerson> AssignmentPeople { get; set; }
        public virtual ICollection<SeizureProcess> SeizureProcesses { get; set; }
    }
}
