using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Enums;
namespace Dominio.src;

[Table("Slot")]
public class Slot
{
    [Key]
    [Required]
    public Guid id { get; set; }
    public TipoSlot tipoSlot { get; set; }
    public TipoVehiculo tipoVehiculo { get; set; }

    public Slot(TipoSlot tipoSlot, TipoVehiculo tipoVehiculo)
    {
        this.tipoSlot = tipoSlot;
        this.tipoVehiculo = tipoVehiculo;
    }

    public Slot()
    {
    }
    public void Actualizar(int TipoSlot, int TipoVehiculo)
    {
        this.tipoSlot = (TipoSlot)tipoSlot;
        this.tipoVehiculo = (TipoVehiculo)tipoVehiculo;
    }
}