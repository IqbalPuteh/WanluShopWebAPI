using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Top10MonthlyCust
    {
        public int? Comm { get; set; }
        public string CustomerName { get; set; } = null!;
        public string? Month { get; set; }
        public string? Year { get; set; }
    }
}
