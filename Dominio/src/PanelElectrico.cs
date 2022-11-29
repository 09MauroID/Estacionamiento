using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("PanelElectrico")]
public class PanelElectrico
{

    [Key]
    [Required]
    public Guid id { get; set; }

    public PanelElectrico(Guid id)
    {
        this.id = id;
    }

    public PanelElectrico()
    {
    }

    public void pagarCarga()
    {

    }
    public void CargarVehiculoElectrico()
    {

    }
}