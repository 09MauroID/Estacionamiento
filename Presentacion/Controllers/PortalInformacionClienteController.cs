using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers;
[ApiController]
[Route("api/[Controller]")]

public class PortalInformacionClienteController : ControllerBase
{
    /*public PresentacionDbContext contexto { get; }
    public PortalInformacionClienteController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var portalInformacionClientes = contexto.PortalInformacionClientes;
        return Ok(portalInformacionClientes);
    }
    [HttpPost]
    public ActionResult Post([FromBody] PortalInformacionClienteViewModel portalInformacionCliente)
    {
        var ticketEntrada = contexto.TicketEntradas.FirstOrDefault(x => x.id == portalInformacionCliente.IdticketEntrada);
        var nuevoportalInformacionCliente = new PortalInformacionCliente(portalInformacionCliente.ticketSalida, portalInformacionCliente.PagoTicket, ticketEntrada!);
        contexto.Add(nuevoportalInformacionCliente);
        contexto.SaveChanges();
        //return StatusCode(StatusCodes.Status201Created);
        return Created($"api/PortalInformacionCliente/{portalInformacionCliente.id}", portalInformacionCliente);
    }*/
}