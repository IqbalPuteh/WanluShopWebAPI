using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Top10Customer
    {
        public int? Comm { get; set; }
        public Guid CustomerId { get; set; }
        public string OutletTown { get; set; } = null!;
        public string? Month { get; set; }
        public string? Year { get; set; }
    }
}
