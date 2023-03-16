using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Product : BaseEntityName<Guid>
    {
        public Product()
        {
            SeizureProducts = new HashSet<SeizureProduct>();
        }

        public string ProductCode { get; set; } = null!;
        public string ScientificName { get; set; } = null!;
        public string? Concentration { get; set; }
        public string? Packaging { get; set; }
        public bool Status { get; set; }
        public int? PharmaceuticalFormId { get; set; }

        public virtual PharmaceuticalForm? PharmaceuticalForm { get; set; }
        public virtual ICollection<SeizureProduct> SeizureProducts { get; set; }
    }
}
