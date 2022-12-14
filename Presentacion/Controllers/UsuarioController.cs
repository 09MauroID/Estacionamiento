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
    [HttpPost]
    public ActionResult Post([FromBody] UsuarioViewModel usuario)
    {
        var nuevoUsuario = new Usuario(usuario.nombre, usuario.contraseña);
        contexto.Add(nuevoUsuario);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }
    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] UsuarioViewModel usuario, Guid id)

    {
        var usuarioModificar = contexto.Usuarios.FirstOrDefault(x => x.id == id);
        if (usuarioModificar is null)
            throw new Exception("no existe un usuario con ese Id.");

        usuarioModificar.ActualizarUsuario(usuario.nombre, usuario.contraseña);
        contexto.SaveChanges();
        return Ok(usuarioModificar);
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var usuarioBorrar = contexto.Usuarios.FirstOrDefault(x => x.id == id);
        if (usuarioBorrar is null)
            throw new Exception("no existe un usuario con ese Id.");

        contexto.Usuarios.Remove(usuarioBorrar);
        contexto.SaveChanges();
        return Ok();
    }
}
