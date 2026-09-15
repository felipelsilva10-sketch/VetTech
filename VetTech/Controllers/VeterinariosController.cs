using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Models;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Veterinario>> GetVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);

            if (veterinario == null)
            {
                return NotFound();
            }

            return veterinario;
        }

        
        [HttpPost]
        public async Task<ActionResult<Veterinario>> PostVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetVeterinario),
                new { id = veterinario.Id },
                veterinario
            );
        }

   
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVeterinario(
            int id,
            Veterinario veterinario)
        {
            if (id != veterinario.Id)
            {
                return BadRequest();
            }

            _context.Entry(veterinario).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);

            if (veterinario == null)
            {
                return NotFound();
            }

            _context.Veterinarios.Remove(veterinario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}