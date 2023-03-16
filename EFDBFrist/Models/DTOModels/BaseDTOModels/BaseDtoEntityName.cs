using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.Models.BaseModel
{
    public class BaseDtoEntityName<TKey> : BaseDtoEntity<TKey>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
