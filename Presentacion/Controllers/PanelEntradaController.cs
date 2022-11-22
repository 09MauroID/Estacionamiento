using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

    public class PanelEntradaController : ControllerBase
    {
        public PresentacionDbContext contexto { get; }
        public PanelEntradaController(PresentacionDbContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var panelEntradas = contexto.PanelEntradas;
            return Ok(panelEntradas);
        }
    }