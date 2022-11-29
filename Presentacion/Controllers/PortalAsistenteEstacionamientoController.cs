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

<<<<<<< HEAD
        [HttpGet]
        public ActionResult Get()
        {
            var portalAsistenteEstacionamientos = contexto.PortalAsistenteEstacionamientos;
            return Ok(portalAsistenteEstacionamientos);
        }
        //[HttpPost]
        //public ActionResult Post([FromBody] PortalAsistenteEstacionamientoViewModel )
    }
=======
    [HttpGet]
    public ActionResult Get()
    {
        var portalAsistenteEstacionamientos = contexto.PortalAsistenteEstacionamientos;
        return Ok(portalAsistenteEstacionamientos);
    }
}
>>>>>>> 68520a82137fbb7a0ef43e3b40346f91266ae9ef
