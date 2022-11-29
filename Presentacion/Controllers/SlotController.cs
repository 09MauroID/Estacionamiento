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
<<<<<<< HEAD
    public PresentacionDbContext contexto { get; }
=======
    /*public PresentacionDbContext contexto { get; }
>>>>>>> 68520a82137fbb7a0ef43e3b40346f91266ae9ef
    public SlotController(PresentacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var slots = contexto.Slots;
        return Ok(slots);
<<<<<<< HEAD
    }
    [HttpGet]
    public ActionResult Post([FromBody] SlotViewModel slot)
    {
        var nuevoSlot = new Slot((TipoSlot)slot.TipoSlot, (TipoVehiculo)slot.TipoVehiculo);
        contexto.Add(nuevoSlot);
        contexto.SaveChanges();
        return Created($"api/Slot/{nuevoSlot.id}", nuevoSlot);
    }
=======
    }*/
>>>>>>> 68520a82137fbb7a0ef43e3b40346f91266ae9ef
}