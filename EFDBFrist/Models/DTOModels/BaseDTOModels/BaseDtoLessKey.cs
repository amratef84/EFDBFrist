using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.Models.BaseModel
{
    public class BaseDtoLessKey<TKey>
    {
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public TKey? CreateById { get; set; }
        public TKey? UpdateById { get; set; }
    }
}
