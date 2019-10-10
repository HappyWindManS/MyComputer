using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZKGDataAPI.Models;
using ZKGDataAPI.TabelModels;

namespace ZKGDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorSoresController : ControllerBase
    {
        private readonly ZKGDataAPIContext _context;

        public MajorSoresController(ZKGDataAPIContext context)
        {
            _context = context;
        }

        // GET: api/MajorSores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MajorSore>>> GetMajorSore()
        {
            return await _context.MajorSore.ToListAsync();
        }

        // GET: api/MajorSores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MajorSore>> GetMajorSore(Guid id)
        {
            var majorSore = await _context.MajorSore.FindAsync(id);

            if (majorSore == null)
            {
                return NotFound();
            }

            return majorSore;
        }

        // PUT: api/MajorSores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMajorSore(Guid id, MajorSore majorSore)
        {
            if (id != majorSore.guid)
            {
                return BadRequest();
            }

            _context.Entry(majorSore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MajorSoreExists(id))
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

        // POST: api/MajorSores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MajorSore>> PostMajorSore(MajorSore majorSore)
        {
            _context.MajorSore.Add(majorSore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMajorSore", new { id = majorSore.guid }, majorSore);
        }

        // DELETE: api/MajorSores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MajorSore>> DeleteMajorSore(Guid id)
        {
            var majorSore = await _context.MajorSore.FindAsync(id);
            if (majorSore == null)
            {
                return NotFound();
            }

            _context.MajorSore.Remove(majorSore);
            await _context.SaveChangesAsync();

            return majorSore;
        }

        private bool MajorSoreExists(Guid id)
        {
            return _context.MajorSore.Any(e => e.guid == id);
        }
    }
}
