using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]
public class PortalAsistenteEstacionamientoController : ControllerBase
{
    public PresentacionDbContext contexto { get; }
    public PortalAsistenteEstacionamientoController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var portalAsistenteEstacionamientos = contexto.PortalAsistenteEstacionamientos;
        return Ok(portalAsistenteEstacionamientos);
    }
    [HttpPost]
    public ActionResult Post([FromBody] PortalAsistenteEstacionamientoViewModel portalAsistenteEstacionamiento)
    {
        var nuevoportalAsistenteEstacionamiento = new PortalAsistenteEstacionamiento();

        foreach (var idAsistente in portalAsistenteEstacionamiento.Asistentes)
        {
            var asistente = contexto.Asistentes.FirstOrDefault(x => x.id == idAsistente);

            if (asistente is not null)
            {
                nuevoportalAsistenteEstacionamiento.AgregarAsistente(asistente);
                contexto.SaveChanges();
            }
        }
        return Created($"api/PortalAsistenteEstacionamiento/{nuevoportalAsistenteEstacionamiento.id}", nuevoportalAsistenteEstacionamiento);
    }

}
