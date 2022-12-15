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
    
    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] SlotViewModel slot, Guid id)
    {
        var slotModificar = contexto.Slots.FirstOrDefault(x => x.id == id);
        if (slotModificar is null)
            throw new Exception("no existe un slot  con ese Id.");

        slotModificar.Actualizar(slot.TipoSlot, slot.TipoVehiculo);

        contexto.SaveChanges();

        return Ok(slotModificar);
    }
    
    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var slotBorrar = contexto.Slots.FirstOrDefault(x => x.id == id);
        if (slotBorrar is null)
            throw new Exception("no existe un slot  con ese Id.");

        contexto.Slots.Remove(slotBorrar);

        contexto.SaveChanges();

        return Ok();
    }
}