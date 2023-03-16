using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class PortOfEntry : BaseEntityName<Guid>
    {
        public PortOfEntry()
        {
            SeizureProcesses = new HashSet<SeizureProcess>();
        }

     
        public string? Code { get; set; }
        public bool Status { get; set; }      
        public string? Address { get; set; }

        public virtual ICollection<SeizureProcess> SeizureProcesses { get; set; }
    }
}
