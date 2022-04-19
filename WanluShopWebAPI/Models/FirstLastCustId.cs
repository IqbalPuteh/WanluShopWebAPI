using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class FirstLastCustId
    {
        public Guid CustomerId { get; set; }
        public string OutletId { get; set; } = null!;
    }
}
