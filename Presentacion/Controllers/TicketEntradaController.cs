using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

    public class TicketEntradaController : ControllerBase
    {
        public PresentacionDbContext contexto { get; }
        public TicketEntradaController(PresentacionDbContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var tickets = contexto.TicketEntradas;
            return Ok(tickets);
        }
        
    }