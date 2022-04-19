using System;
using System.Collections.Generic;

namespace WanluShopWebAPI.Models
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }
        public string? ProductName { get; set; }
    }
}
