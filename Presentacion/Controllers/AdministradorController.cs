using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AdministradorController : ControllerBase
{
    public PresentacionDbContext contexto { get; }
    public AdministradorController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var Administradores = contexto.Administradores;
        return Ok(Administradores);
    }
    [HttpGet("{id:Guid}")]
    public ActionResult Get(Guid id)
    {
        var Administrador = contexto.Administradores.FirstOrDefault(x => x.id == id);
        return Ok(Administrador);
    }

    [HttpPost]
    public ActionResult Post([FromBody] AdministradorViewModel administrador)
    {
        var nuevoAdministrador = new Administrador(administrador.nombre, administrador.contraseña);
        contexto.Add(nuevoAdministrador);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPost("/api/Administrador/{idAdministrador:Guid}/Usuario/{idUsuario:Guid}")]
    public ActionResult AsignarUsuario(Guid idAdministrador, Guid idUsuario)
    {
        var nuevoAdministrador = contexto.Administradores.FirstOrDefault(a => a.id == idAdministrador);
        var usuario = contexto.Usuarios.FirstOrDefault(a => a.id == idUsuario);
        nuevoAdministrador.AsignarUsuario(usuario);
        contexto.SaveChanges();
        return Ok("Se asigno usuario");
    }


    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] AdministradorViewModel administrador, Guid id)
    {
        var administradorModificar = contexto.Administradores.FirstOrDefault(x => x.id == id);

        if (administradorModificar is null)
            throw new Exception("no existe un administrador  con ese Id.");

        administradorModificar.Actualizar(administrador.nombre, administrador.contraseña);
        contexto.SaveChanges();
        return Ok(administradorModificar);
    }
    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var administradorBorrar = contexto.Administradores.FirstOrDefault(x => x.id == id);

        if (administradorBorrar is null)
            throw new Exception("no existe un administrados con ese Id.");

        contexto.Administradores.Remove(administradorBorrar);
        contexto.SaveChanges();
        return Ok();
    }
}