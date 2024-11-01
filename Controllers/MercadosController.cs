using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMeu.Data;
using ApiMeu.Models;

namespace ApiMeu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercadosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MercadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Mercados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mercado>>> GetMercado()
        {
            return await _context.Mercado.ToListAsync();
        }

        // GET: api/Mercados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mercado>> GetMercado(Guid id)
        {
            var mercado = await _context.Mercado.FindAsync(id);

            if (mercado == null)
            {
                return NotFound();
            }

            return mercado;
        }

        // PUT: api/Mercados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMercado(Guid id, Mercado mercado)
        {
            if (id != mercado.Id)
            {
                return BadRequest();
            }

            _context.Entry(mercado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MercadoExists(id))
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

        // POST: api/Mercados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mercado>> PostMercado(Mercado mercado)
        {
            _context.Mercado.Add(mercado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMercado", new { id = mercado.Id }, mercado);
        }

        // DELETE: api/Mercados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMercado(Guid id)
        {
            var mercado = await _context.Mercado.FindAsync(id);
            if (mercado == null)
            {
                return NotFound();
            }

            _context.Mercado.Remove(mercado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MercadoExists(Guid id)
        {
            return _context.Mercado.Any(e => e.Id == id);
        }
    }
}
