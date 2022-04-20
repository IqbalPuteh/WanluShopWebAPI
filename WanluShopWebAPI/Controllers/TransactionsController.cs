using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WanluShopWebAPI.Models;


namespace WanluShopWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext _context;

        public TransactionsController(WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext context)
        {
            _context = context;
        }


        // GET: api/Transactions

        [HttpGet("01-GetPriceMinMax")]
        public IEnumerable<PriceMinMax> GetPriceMinMax()
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                return Context.PriceMinMaxes.ToList();
            }
        }

        [HttpGet("02-GetCustomerFirstLast")]
        public IEnumerable<CustomerFirstLast> GetCustomerFirstLast(string strCity)
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                var CustomerFirstLast = from CustFirstLast in Context.CustomerFirstLasts
                                        where CustFirstLast.OutletTown == strCity
                                        select CustFirstLast;
                
                return CustomerFirstLast.ToList();
            }
        }

        [HttpGet("03-GetMonthlyTopTenItemSale")]
        public IEnumerable<MonthlyTopItemSale> GetMonthlyTopTenItemSale(string strCity, string Month, string Year)
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                var queryOutletCity = (from Outlet in Context.MonthlyTopItemSales
                                       where Outlet.OutletTown == strCity && Outlet.Month == Month && Outlet.Year == Year
                                       orderby Outlet.Total descending
                                       select Outlet).Take(10);

                return queryOutletCity.ToList();
            }
        }

        [HttpGet("04-GetTop10MonthlyCusts")]
        public IEnumerable<Top10MonthlyCust> GetTop10MonthlyCusts(string strCity, string Month , string Year)
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                var queryTop10Customer = (from Cust in Context.Top10MonthlyCusts
                                          where Cust.OutletTown == strCity && Cust.Month == Month && Cust.Year == Year
                                          orderby Cust.Comm descending
                                          select Cust).Take(10);

                return queryTop10Customer.ToList();
            }
        }

        [HttpGet("05-GetYearlyTran")]
        public IEnumerable<YearlyTran> GetYearlyTran(string strCity,  string Year)
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                var queryYearlyTran = from Yearly in Context.YearlyTrans
                                      where Yearly.OutletTown == strCity && Yearly.Year == Year
                                      select Yearly;

                return queryYearlyTran.ToList();
            }
        }

        [HttpGet("06-Top5MonthlySalesItem")]
        public IEnumerable<Top5MonthlySalesItem> GetTop5MonthlySalesItem()
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {

                var Top5MonthlySales = from Top5Monthly in Context.Top5MonthlySalesItems
                                       where Top5Monthly.Diff > 0
                                       orderby Top5Monthly.Diff descending
                                       select Top5Monthly;
                
                return Top5MonthlySales.ToList();
            }
        }
    }
}
