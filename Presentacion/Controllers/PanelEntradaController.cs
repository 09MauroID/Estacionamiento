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
    [HttpPost]
    public ActionResult Post([FromBody] PanelEntradaViewModel panelEntrada)
    {
        var nuevopanelEntrada = new PanelEntrada(panelEntrada.ubicacion);
        contexto.PanelEntradas.Add(nuevopanelEntrada);
        contexto.SaveChanges();
        return Created($"api/PanelEntrada/{nuevopanelEntrada.id}", nuevopanelEntrada);
    }

    [HttpPost]
    [Route("{idPanelEntrada:Guid}/TicketEntrada")]
    public ActionResult AgregarTicketEntrada([FromBody] TicketEntradaViewModel ticketEntrada, Guid idPanelEntrada)
    {
        var panelEntrada = contexto.PanelEntradas.FirstOrDefault(x => x.id == idPanelEntrada);
        var ticketEntrada1 = new TicketEntrada(ticketEntrada.matricula, ticketEntrada.tipoVehiculo, ticketEntrada.horarioIngreso, ticketEntrada.Monto);

        panelEntrada.AgregarTicketEntrada(ticketEntrada1);

        contexto.SaveChanges();
        return Created($"api/PanelEntrada/{ticketEntrada1.id}", ticketEntrada);
    }

    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] PanelEntradaViewModel panelEntrada, Guid id)
    {
        var panelEntradaModificar = contexto.PanelEntradas.FirstOrDefault(x => x.id == id);

        panelEntradaModificar.Actualizar(panelEntradaModificar.ubicacion);

        contexto.SaveChanges();

        return Ok(panelEntradaModificar);
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var panelEntradaBorrar = contexto.PanelEntradas.FirstOrDefault(x => x.id == id);

        contexto.PanelEntradas.Remove(panelEntradaBorrar);

        contexto.SaveChanges();

        return Ok();
    }
}