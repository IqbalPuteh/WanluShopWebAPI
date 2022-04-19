using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Transaction
    {
        public Guid TransId { get; set; }
        public string OutletId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public string? Date { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public int Qty { get; set; }
    }
}
