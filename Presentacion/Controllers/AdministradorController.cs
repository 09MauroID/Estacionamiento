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
}

