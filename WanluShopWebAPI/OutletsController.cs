#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WanluShopWebAPI.Models;

namespace WanluShopWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletsController : ControllerBase
    {
        private readonly WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext _context;

        public OutletsController(WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext context)
        {
            _context = context;
        }

        // GET: api/Outlets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Outlet>>> GetOutlets()
        {
            return await _context.Outlets.ToListAsync();
        }

        // GET: api/Outlets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Outlet>> GetOutlet(Guid id)
        {
            var outlet = await _context.Outlets.FindAsync(id);

            if (outlet == null)
            {
                return NotFound();
            }

            return outlet;
        }

        // PUT: api/Outlets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutlet(Guid id, Outlet outlet)
        {
            if (id != outlet.OutletId)
            {
                return BadRequest();
            }

            _context.Entry(outlet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutletExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Outlets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Outlet>> PostOutlet(Outlet outlet)
        {
            _context.Outlets.Add(outlet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOutlet", new { id = outlet.OutletId }, outlet);
        }

        // DELETE: api/Outlets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutlet(Guid id)
        {
            var outlet = await _context.Outlets.FindAsync(id);
            if (outlet == null)
            {
                return NotFound();
            }

            _context.Outlets.Remove(outlet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OutletExists(Guid id)
        {
            return _context.Outlets.Any(e => e.OutletId == id);
        }
    }
}
