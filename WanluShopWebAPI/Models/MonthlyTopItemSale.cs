using System;


namespace WanluShopWebAPI.Models
{
    public partial class MonthlyTopItemSale
    {
        public int? Total { get; set; }
        public string OutletTown { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
    }
}
