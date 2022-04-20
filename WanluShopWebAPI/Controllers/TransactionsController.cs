using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WanluShopWebAPI.Models;
//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;


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

        private bool TransactionExists(Guid id)
        {
            return _context.Transactions.Any(e => e.TransId == id);
        }

        // GET: api/Transactions

        [HttpGet("{test}")]
        public IEnumerable<Product> Get()
        {

            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                return Context.Products.ToList();
            }
        }

        [HttpGet("{1}CustomerFirstLast")]
        public IEnumerable<CustomerFirstLast> GetCustomerFirstLast()
        {
            using (var Context = new WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext())
            {
                return Context.CustomerFirstLasts.ToList();
            }
        }
    }
}
