using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database_Connector;
using Entities;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocabulariesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VocabulariesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vocabularies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vocabulary>>> GetVocabulary()
        {
            return await _context.Vocabulary.ToListAsync();
        }

        // GET: api/Vocabularies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vocabulary>> GetVocabulary(int id)
        {
            var vocabulary = await _context.Vocabulary.FindAsync(id);

            if (vocabulary == null)
            {
                return NotFound();
            }

            return vocabulary;
        }

        // PUT: api/Vocabularies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVocabulary(int id, Vocabulary vocabulary)
        {
            if (id != vocabulary.Id)
            {
                return BadRequest();
            }

            _context.Entry(vocabulary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VocabularyExists(id))
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

        // POST: api/Vocabularies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vocabulary>> PostVocabulary(Vocabulary vocabulary)
        {
            _context.Vocabulary.Add(vocabulary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVocabulary", new { id = vocabulary.Id }, vocabulary);
        }

        // DELETE: api/Vocabularies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVocabulary(int id)
        {
            var vocabulary = await _context.Vocabulary.FindAsync(id);
            if (vocabulary == null)
            {
                return NotFound();
            }

            _context.Vocabulary.Remove(vocabulary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VocabularyExists(int id)
        {
            return _context.Vocabulary.Any(e => e.Id == id);
        }
    }
}
