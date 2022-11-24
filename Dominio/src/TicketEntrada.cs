using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("TicketEntrada")]
public class TicketEntrada
{
    [Key]
    [Required]
    public Guid id { get; set; }
    [StringLength(50)]
    [Required]
    public string? matricula { get; set; }
    [StringLength(50)]
    [Required]
    public string? tipoVehiculo { get; set; }
    public DateTime horarioIngreso { get; set; }
    [Required]
    public int Monto { get; set; }
    public PanelSalida panelSalida { get; set; }

    public TicketEntrada(string matricula, string tipoVehiculo, DateTime horarioIngreso, PanelSalida panelSalida, int Monto)
    {
        this.matricula = matricula;
        this.tipoVehiculo = tipoVehiculo;
        this.horarioIngreso = horarioIngreso;
        this.panelSalida = panelSalida;
        this.Monto = Monto;
    }
}