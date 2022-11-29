using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]
public class PortalAsistenteEstacionamientoController : ControllerBase
{
    /*public PresentacionDbContext contexto { get; }
    public PortalAsistenteEstacionamientoController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var portalAsistenteEstacionamientos = contexto.PortalAsistenteEstacionamientos;
        return Ok(portalAsistenteEstacionamientos);
    }*/
}