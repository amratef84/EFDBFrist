using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class PharmaceuticalForm : BaseEntityName<Guid>
    {
        public PharmaceuticalForm()
        {
            Products = new HashSet<Product>();
        }

        public int AmountOfSamplesDrawn { get; set; }
       
        public virtual ICollection<Product> Products { get; set; }
    }
}
