using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AsistenteController : ControllerBase
{
    /*public PresentacionDbContext contexto { get; }
    public AsistenteController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var Asistentes = contexto.Asistentes;
        return Ok(Asistentes);
    }
    [HttpGet("{id:Guid}")]
    public ActionResult Get(Guid id)
    {
        var Asistente = contexto.Asistente.FirstOrDefault(x => x.id == id);
        return Ok(Asistente);
    }
    [HttpGet]
    public ActionResult Post([FromBody] UsuarioViewModel Asistente)
    {
        var nuevoAsistente = new Asistente(Asistente.Nombre, Asistente.Contraseña);
        contexto.Add(nuevoAsistente);
        contexto.SaveChanger();
        return Statuscode(StatusCode.Status201Created);
    }*/
}
