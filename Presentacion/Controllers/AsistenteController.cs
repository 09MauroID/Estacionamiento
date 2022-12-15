using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AsistenteController : ControllerBase
{
    public PresentacionDbContext contexto { get; }
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
        var Asistente = contexto.Asistentes.FirstOrDefault(x => x.id == id);
        return Ok(Asistente);
    }
    [HttpPost]
    public ActionResult Post([FromBody] AsistenteViewModel asistente)
    {
        var nuevoAsistente = new Asistente(asistente.nombre, asistente.contrasenia);
        contexto.Add(nuevoAsistente);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }
    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] AsistenteViewModel asistente, Guid id)
    {
        var asistenteModificar = contexto.Asistentes.FirstOrDefault(x => x.id == id);
        
        if (asistenteModificar is null)
            throw new Exception("no existe un asistente  con ese Id.");

        asistenteModificar.Actualizar(asistente.nombre, asistente.contrasenia);

        contexto.SaveChanges();

        return Ok(asistenteModificar);
    }
    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var asistenteBorrar = contexto.Asistentes.FirstOrDefault(x => x.id == id);
        if (asistenteBorrar is null)
            throw new Exception("no existe un asistente  con ese Id.");

        contexto.Asistentes.Remove(asistenteBorrar);

        contexto.SaveChanges();

        return Ok();
    }
}