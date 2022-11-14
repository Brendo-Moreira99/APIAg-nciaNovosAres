using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovosAresApi.NET.Models;

namespace NovosAresApi.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : ControllerBase
    {
        private readonly NovosAresDBContext _context;



        public PacoteController(NovosAresDBContext context)
        {
            _context = context;
        }



        //GET: api/Pacote - Lista todos os pacotes
        [HttpGet]
        public IEnumerable<Pacote> GetPacotes()
        {
            return _context.Pacotes;
        }



        //GET: api/PAcote/id - Lista pacote por id
        [HttpGet("{id}")]
        public IActionResult GetPacotePorId(int id)
        {
            Pacote pacote = _context.Pacotes.SingleOrDefault(modelo => modelo.PacoteId == id);
            if (pacote == null)
            {
                return NotFound();
            }
            return new ObjectResult(pacote);
        }



        // Cria
        [HttpPost]
        public IActionResult CriarPacote(Pacote item)
        {
            if (item == null)
            {
                return BadRequest();
            }



            _context.Pacotes.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);
        }



        // Atualiza
        [HttpPut("{id}")]
        public IActionResult AtualizaPacote(int id, Pacote item)
        {
            if (id != item.PacoteId)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();



            return new NoContentResult();
        }



        // Deleta
        [HttpDelete("{id}")]
        public IActionResult DeletaPacote(int id)
        {
            var pacote = _context.Pacotes.SingleOrDefault(m => m.PacoteId == id);



            if (pacote == null)
            {
                return BadRequest();
            }



            _context.Pacotes.Remove(pacote);
            _context.SaveChanges();
            return Ok(pacote);
        }


    }
}
