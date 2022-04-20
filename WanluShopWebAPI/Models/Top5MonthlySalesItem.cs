using System;


namespace WanluShopWebAPI.Models
{
    public partial class Top5MonthlySalesItem
    {
        public string? ProductName { get; set; }
        public int? CurrentSales { get; set; }
        public int? PreviousSales { get; set; }
        public int? Diff { get; set; }
    }
}
