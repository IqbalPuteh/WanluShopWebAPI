using System;


namespace WanluShopWebAPI.Models
{
    public partial class CustomerFirstLast
    {
        public string CustomerName { get; set; } = null!;
        public string OutletTown { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
    }
}
