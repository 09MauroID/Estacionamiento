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
    public TipoSlot TipoSlot { get; set; }
    public TipoVehiculo tipoVehiculo { get; set; }

    public Slot(TipoSlot tipo, TipoVehiculo tipoVehiculo)
    {
        TipoSlot = tipo;
        this.tipoVehiculo = tipoVehiculo;
    }

    public Slot()
    {
    }
}