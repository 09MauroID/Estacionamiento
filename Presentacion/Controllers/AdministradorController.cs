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
    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] AdministradorViewModel administrador, Guid id) 
    {
        var administradorModificar = contexto.Administradores.FirstOrDefault(x => x.id == id);
        
         if (administradorModificar is null)
            throw new Exception("no existe un administrador de entrada con ese Id.");

        administradorModificar.Actualizar(administrador.nombre, administrador.contraseña);
        contexto.SaveChanges();
        return Ok(administradorModificar);
    }
    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var administradorBorrar = contexto.Administradores.FirstOrDefault(x => x.id == id);

         if (administradorBorrar is null)
            throw new Exception("no existe un administrados de entrada con ese Id.");

        contexto.Administradores.Remove(administradorBorrar);
        contexto.SaveChanges();
        return Ok();
    }
}

