using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    public PresentacionDbContext contexto { get; }
    public UsuarioController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;

    }
    [HttpGet]
    public ActionResult Get()
    {
        var usuario = contexto.Usuarios;
        return Ok(usuario);
    }
    [HttpGet("{id:Guid}")]
    public ActionResult Get(Guid id)
    {
        var Usuario = contexto.Usuarios.FirstOrDefault(x => x.id == id);
        return Ok(Usuario);
    }
    [HttpGet]
    public ActionResult Post([FromBody] UsuarioViewModel usuario)
    {
        var nuevoUsuario = new Usuario(usuario.nombre, usuario.contraseña);
        contexto.Add(nuevoUsuario);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);

    }
}
