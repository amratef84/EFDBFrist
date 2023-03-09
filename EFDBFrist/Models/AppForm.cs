using System;
using System.Collections.Generic;

namespace EFDBFrist.Models
{
    public partial class AppForm
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public int Parent { get; set; }
    }
}
