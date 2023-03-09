using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class SeizureProcess
    {
        public SeizureProcess()
        {
            SampleLabSends = new HashSet<SampleLabSend>();
            SeizureProducts = new HashSet<SeizureProduct>();
        }

        public int Id { get; set; }
        public string? ReasonForSeizure { get; set; }
        public int Status { get; set; }
        public int SeizureType { get; set; }
        public string? ShipmentType { get; set; }
        public string? InvoiceNo { get; set; }
        public int ReferenceNo { get; set; }
        public string? ReferenceNo2 { get; set; }
        public DateTime? UploadDate { get; set; }
        public int AssignmentId { get; set; }
        public int CompanyId { get; set; }
        public int SupplierId { get; set; }
        public int PortOfEntryId { get; set; }
        public int? UserId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Assignment Assignment { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual PortOfEntry PortOfEntry { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual User? User { get; set; }
        public virtual ICollection<SampleLabSend> SampleLabSends { get; set; }
        public virtual ICollection<SeizureProduct> SeizureProducts { get; set; }
    }
}
