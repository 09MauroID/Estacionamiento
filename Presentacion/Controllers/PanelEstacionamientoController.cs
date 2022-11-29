using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[controller]")]

public class PanelEstacionamientoController : ControllerBase
{
    /*public PresentacionDbContext contexto { get; }
    public PanelEstacionamientoController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }
    [HttpGet]
    public ActionResult Get()
    {
        var PanelEstacionamientos = contexto.PanelEstacionamientos;
        return Ok(PanelEstacionamientos);
    }*/


}
