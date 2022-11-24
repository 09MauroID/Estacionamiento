using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

    public class SlotController : ControllerBase
    {
        public PresentacionDbContext contexto { get; }
        public SlotController(PresentacionDbContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var slots = contexto.Slots;
            return Ok(slots);
        }
    }