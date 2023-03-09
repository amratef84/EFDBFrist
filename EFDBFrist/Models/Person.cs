using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class Person
    {
        public Person()
        {
            AssignmentPeople = new HashSet<AssignmentPerson>();
        }

        public int Id { get; set; }
        public string? Address { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? CreateById { get; set; }
        public int? UpdateById { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<AssignmentPerson> AssignmentPeople { get; set; }
    }
}
