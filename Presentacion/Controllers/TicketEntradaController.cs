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
    [HttpPost]
    public ActionResult Post([FromBody] TicketEntradaViewModel ticketEntrada)
    {
        var nuevoticketEntrada = new TicketEntrada(ticketEntrada.matricula, ticketEntrada.tipoVehiculo, ticketEntrada.horarioIngreso, ticketEntrada.Monto);
        contexto.Add(nuevoticketEntrada);
        contexto.SaveChanges();
        //return StatusCode(StatusCodes.Status201Created);
        return Created($"api/TicketEntrada/{nuevoticketEntrada.id}", nuevoticketEntrada);
    }

    [HttpDelete]
    public ActionResult Delete(Guid id)
    {
        var ticketBorrar = contexto.TicketEntradas.FirstOrDefault(x => x.id == id);
        if (ticketBorrar is null)
            throw new Exception("no existe un ticket con ese Id.");


        contexto.TicketEntradas.Remove(ticketBorrar);

        contexto.SaveChanges();

        return Ok();
    }
}