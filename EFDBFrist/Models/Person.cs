﻿using EFDBFrist.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Person :BaseEntityName<Guid>
    {
    //    public Person()
    //    {
    //        AssignmentPeople 
    //    }
        public string? Address { get; set; }
        public bool Status { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public List<AssignmentPerson> AssignmentPeople { get; set; } = new List<AssignmentPerson>();
    }
}
