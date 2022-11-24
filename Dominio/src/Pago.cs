using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Pago")]
public class Pago
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    [Required]
    public string? tipoPago { get; set; }
    [Required]
    public int montodePago { get; set; }

    public Pago(string tipoPago, int montodePago)
    {
        this.tipoPago = tipoPago;
        this.montodePago = montodePago;
    }
}