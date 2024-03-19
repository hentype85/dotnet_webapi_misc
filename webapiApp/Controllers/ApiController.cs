using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiApp.Context;
using webapiApp.Models;

[ApiController]
[Route("[controller]")]
public class apiController : ControllerBase
{
    // instancia de la base de datos para Entity Framework Core
    private readonly ApplicationDbContext _context;

    // el constructor recibe una instancia de ApplicationDbContext mediante inyección de dependencias
    public apiController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET 
    [HttpGet("get/usuarios")]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
    {
        // listar todos los usuarios
        List<Usuario> lstUsuarios = await _context.Usuarios.ToListAsync();
        return Ok(lstUsuarios);
    }

    // GET
    [HttpGet("get/usuariosPaginado")]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuariosPaginado(int pagina = 0)
    {
        int tamanoPagina = 10;
        int indiceInicio = pagina * tamanoPagina; // indice de inicio

        if (pagina < 0)
        {
            return BadRequest("El numero de pagina no puede ser negativo.");
        }

        // obtener los usuarios paginados desde la base de datos
        List<Usuario> lstUsuarios = await _context.Usuarios
            .Skip(indiceInicio)
            .Take(tamanoPagina)
            .ToListAsync();

        if (lstUsuarios.Count == 0)
        {
            return NotFound("No se encontraron usuarios");
        }

        return Ok(lstUsuarios);
    }

     // GET
    [HttpGet("get/usuario/{id}")]
    public async Task<ActionResult<Usuario>> GetUsuarioId(int id)
    {
        // obtiene usuario por id
        Usuario usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null)
        {
            return NotFound();
        }
        return Ok(usuario);
    }

    // POST
    [HttpPost("post/usuario")]
    public async Task<ActionResult<Usuario>> PostUsuario([FromBody] Usuario nuevoUsuario)
    {
        if (nuevoUsuario == null)
        {
            return BadRequest("Datos de usuario incorrectos");
        }

        try
        {
            // agregar usuario a la base de datos
            _context.Usuarios.Add(nuevoUsuario);

            // guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            // proporcionar nuevo recurso creado
            return CreatedAtAction("ObtenerUsuarioId", new { id = nuevoUsuario.Id }, nuevoUsuario);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    // PUT
    [HttpPut("put/usuario")]
    public async Task<ActionResult<Usuario>> PutUsuario([FromBody] Usuario modUsuario)
    {
        if (modUsuario == null)
        {
            return BadRequest("Datos de usuario incorrectos");
        }

        try
        {
            // verificar si el usuario existe en la base de datos
            Usuario usuario = await _context.Usuarios.FindAsync(modUsuario.Id);
            if (usuario == null)
            {
                return NotFound("Usuario no encontrado");
            }

            // actualizar propiedades del usuario existente con modUsuario
            usuario.Nombre = modUsuario.Nombre;
            usuario.Apellido = modUsuario.Apellido;
            usuario.Edad = modUsuario.Edad;

            // guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            return Ok(usuario);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    // DELETE
    [HttpDelete("delete/usuario/{id}")]
    public async Task<ActionResult> DeleteUsuario(int id)
    {
        try
        {
            // verificar si el id de usuario existe en la base de datos
            Usuario usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound("Usuario no encontrado");
            }

            // eliminar el usuario de la base de datos
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    // OPTIONS
    [HttpOptions]
    public IActionResult Options()
    {
        Response.Headers.Add("allow", "GET, POST, PUT, DELETE, OPTIONS");
        return Ok();
    }

}
