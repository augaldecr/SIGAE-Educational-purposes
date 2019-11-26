using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGAE.Web.Data;
using SIGAE.Web.Data.Entities.Administrativo.Asesoria;

namespace SIGAE.Web.Controllers.API.Administrativo.Asesoria
{
    [Route("api/[controller]")]
    [ApiController]
    public class GirasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GirasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Giras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gira>>> GetGira()
        {
            return await _context.Giras.ToListAsync();
        }

        // GET: api/Giras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gira>> GetGira(int id)
        {
            var gira = await _context.Giras.FindAsync(id);

            if (gira == null)
            {
                return NotFound();
            }

            return gira;
        }

        // PUT: api/Giras/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGira(int id, Gira gira)
        {
            if (id != gira.Id)
            {
                return BadRequest();
            }

            _context.Entry(gira).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiraExists(id))
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

        // POST: api/Giras
        [HttpPost]
        public async Task<ActionResult<Gira>> PostGira(Gira gira)
        {
            _context.Giras.Add(gira);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGira", new { id = gira.Id }, gira);
        }

        // DELETE: api/Giras/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gira>> DeleteGira(int id)
        {
            var gira = await _context.Giras.FindAsync(id);
            if (gira == null)
            {
                return NotFound();
            }

            _context.Giras.Remove(gira);
            await _context.SaveChangesAsync();

            return gira;
        }

        private bool GiraExists(int id)
        {
            return _context.Giras.Any(e => e.Id == id);
        }
    }
}
