using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovosAresApi.NET.Models;

namespace NovosAresApi.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly NovosAresDBContext _context;



        public ClienteController(NovosAresDBContext context)
        {
            _context = context;
        }



        //GET: api/Cliente - Lista todos os clientes
        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Clientes;
        }



        //GET: api/Cliente/id - Lista cliente por id
        [HttpGet("{id}")]
        public IActionResult GetClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.SingleOrDefault(modelo => modelo.ClienteId == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return new ObjectResult(cliente);
        }



        // Cria
        [HttpPost]
        public IActionResult CriarCliente(Cliente item)
        {
            if (item == null)
            {
                return BadRequest();
            }



            _context.Clientes.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);
        }



        // Atualiza
        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, Cliente item)
        {
            if (id != item.ClienteId)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();



            return new NoContentResult();
        }



        // Deleta
        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(m => m.ClienteId == id);



            if (cliente == null)
            {
                return BadRequest();
            }



            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}

