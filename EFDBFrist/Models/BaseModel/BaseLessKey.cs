using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.Models.BaseModel
{
    public class BaseLessKey<TKey>
    {
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }

        public TKey? CreateById { get; set; }
        public TKey? UpdateById { get; set; }
    }
}
