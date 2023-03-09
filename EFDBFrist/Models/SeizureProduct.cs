using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class SeizureProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string BatchNumber { get; set; } = null!;
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime? AnalysisDate { get; set; }
        public int AmountReal { get; set; }
        public int SampleSendToLab { get; set; }
        public string? Notes { get; set; }
        public int State { get; set; }
        public int SeizureProcessId { get; set; }
        public int? SampleLabTestId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? LabNotes { get; set; }
        public string? LabSendNotes { get; set; }
        public int Result { get; set; }
        public DateTime? SendAnalysisDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual SampleLabTest? SampleLabTest { get; set; }
        public virtual SeizureProcess SeizureProcess { get; set; } = null!;
    }
}
