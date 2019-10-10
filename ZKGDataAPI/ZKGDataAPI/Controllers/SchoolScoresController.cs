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
    public class SchoolScoresController : ControllerBase
    {
        private readonly ZKGDataAPIContext _context;

        public SchoolScoresController(ZKGDataAPIContext context)
        {
            _context = context;


        }

        // GET: api/SchoolScores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolScore>>> GetSchoolScore()
        {
            return await _context.SchoolScore.ToListAsync();
        }

        // GET: api/SchoolScores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolScore>> GetSchoolScore(Guid id)
        {
            var schoolScore = await _context.SchoolScore.FindAsync(id);

            if (schoolScore == null)
            {
                return NotFound();
            }

            return schoolScore;
        }

        // PUT: api/SchoolScores/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchoolScore(Guid id, SchoolScore schoolScore)
        {
            if (id != schoolScore.guid)
            {
                return BadRequest();
            }

            _context.Entry(schoolScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolScoreExists(id))
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

        // POST: api/SchoolScores
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SchoolScore>> PostSchoolScore(SchoolScore schoolScore)
        {
            _context.SchoolScore.Add(schoolScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchoolScore", new { id = schoolScore.guid }, schoolScore);
        }

        // DELETE: api/SchoolScores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SchoolScore>> DeleteSchoolScore(Guid id)
        {
            var schoolScore = await _context.SchoolScore.FindAsync(id);
            if (schoolScore == null)
            {
                return NotFound();
            }

            _context.SchoolScore.Remove(schoolScore);
            await _context.SaveChangesAsync();

            return schoolScore;
        }

        private bool SchoolScoreExists(Guid id)
        {
            return _context.SchoolScore.Any(e => e.guid == id);
        }
    }
}
