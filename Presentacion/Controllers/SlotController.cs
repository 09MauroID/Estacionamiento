using Presentacion.Persistencia;
using Presentacion.ViewModels;
using Dominio.src;
using Microsoft.AspNetCore.Mvc;
using Dominio.Enums;

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
    [HttpPost]
    public ActionResult Post([FromBody] SlotViewModel slot)
    {
        var nuevoSlot = new Slot((TipoSlot)slot.TipoSlot, (TipoVehiculo)slot.TipoVehiculo);
        contexto.Add(nuevoSlot);
        contexto.SaveChanges();
        return Created($"api/Slot/{nuevoSlot.id}", nuevoSlot);
    }
}