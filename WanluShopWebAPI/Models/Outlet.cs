using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Outlet
    {
        public Guid OutletId { get; set; }
        public string? OutletName { get; set; }
        public string OutletTown { get; set; } = null!;
    }
}
