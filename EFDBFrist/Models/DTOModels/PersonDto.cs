using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.Models.DTOModels
{
    public class PersonDto: BaseDtoEntityName<Guid>
    {
        public string? Address { get; set; }
        public bool Status { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

    }
}
