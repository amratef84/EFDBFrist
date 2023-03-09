using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class SampleLabSend
    {
        public int Id { get; set; }
        public bool AnalysisMethod { get; set; }
        public bool AnalysisCertificate { get; set; }
        public bool WorkingStandard { get; set; }
        public int VoucherAnalysisNo { get; set; }
        public string? Notes { get; set; }
        public bool Status { get; set; }
        public int SeizureProcessId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SeizureProcess SeizureProcess { get; set; } = null!;
    }
}
