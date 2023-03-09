using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class PharmaceuticalForm
    {
        public PharmaceuticalForm()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int AmountOfSamplesDrawn { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
