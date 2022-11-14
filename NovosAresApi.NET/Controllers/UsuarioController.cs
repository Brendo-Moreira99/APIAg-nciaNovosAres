using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovosAresApi.NET.Models;

namespace NovosAresApi.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly NovosAresDBContext _context;



        public UsuarioController(NovosAresDBContext context)
        {
            _context = context;
        }



        //GET: api/Usuario - Lista todos os clientes
        [HttpGet]
        public IEnumerable<Usuario> GetUsuario()
        {
            return _context.Usuarios;
        }



        //GET: api/Usuario/id - Lista cliente por id
        [HttpGet("{id}")]
        public IActionResult GetUsuarioPorId(int id)
        {
            Usuario usuario = _context.Usuarios.SingleOrDefault(modelo => modelo.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return new ObjectResult(usuario);
        }



        // Cria
        [HttpPost]
        public IActionResult CriarUsuario(Usuario item)
        {
            if (item == null)
            {
                return BadRequest();
            }



            _context.Usuarios.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);
        }



        // Atualiza
        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, Usuario item)
        {
            if (id != item.UsuarioId)
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
            var usuario = _context.Usuarios.SingleOrDefault(m => m.UsuarioId == id);



            if (usuario == null)
            {
                return BadRequest();
            }



            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

    }
}
