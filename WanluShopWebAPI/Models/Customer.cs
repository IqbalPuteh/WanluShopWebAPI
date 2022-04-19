using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string OutletId { get; set; } = null!;
    }
}
