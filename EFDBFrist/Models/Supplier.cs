using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            AssignmentPeople = new HashSet<AssignmentPerson>();
            SeizureProcesses = new HashSet<SeizureProcess>();
        }

        public int Id { get; set; }
        public string? SupplierCode { get; set; }
        public string? SuperName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Directorate { get; set; }
        public string? Province { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime? LicenseDate { get; set; }
        public string? SiteStore { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<AssignmentPerson> AssignmentPeople { get; set; }
        public virtual ICollection<SeizureProcess> SeizureProcesses { get; set; }
    }
}
