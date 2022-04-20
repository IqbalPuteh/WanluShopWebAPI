using System;


namespace WanluShopWebAPI.Models
{
    public partial class YearlyTran
    {
        public int? Commulative { get; set; }
        public string? Year { get; set; }
        public string OutletTown { get; set; } = null!;
    }
}
