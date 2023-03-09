using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Product
    {
        public Product()
        {
            SeizureProducts = new HashSet<SeizureProduct>();
        }

        public int Id { get; set; }
        public string ProductCode { get; set; } = null!;
        public string ScientificName { get; set; } = null!;
        public string? Concentration { get; set; }
        public string? Packaging { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public int? PharmaceuticalFormId { get; set; }

        public virtual PharmaceuticalForm? PharmaceuticalForm { get; set; }
        public virtual ICollection<SeizureProduct> SeizureProducts { get; set; }
    }
}
