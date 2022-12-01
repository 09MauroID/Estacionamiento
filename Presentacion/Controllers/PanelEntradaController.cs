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
        var ticketEntrada = contexto.TicketEntradas.FirstOrDefault(x => x.id == panelEntrada.IdticketEntrada);
        var nuevopanelEntrada = new PanelEntrada(ticketEntrada!, panelEntrada.ubicacion);
        contexto.Add(nuevopanelEntrada);
        contexto.SaveChanges();
        //return StatusCode(StatusCodes.Status201Created);
        return Created($"api/PanelEntrada/{nuevopanelEntrada.id}", nuevopanelEntrada);
    }
    
    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] PanelEntradaViewModel panelEntrada, Guid id)
    {
        var panelEntradaModificar = contexto.PanelEntradas.FirstOrDefault(x => x.id == id);

        panelEntradaModificar.Actualizar(panelEntrada.ubicacion);

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