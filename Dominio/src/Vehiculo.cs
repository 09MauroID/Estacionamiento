using Dominio.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;

[Table("Vehiculo")]
public class Vehiculo
{
    [Key]
    [Required]
    public string matricula { get; set; }
    public TipoVehiculo tipoVehiculo { get; set; }

    public Vehiculo(string matricula, TipoVehiculo tipoVehiculo)
    {
        this.matricula = matricula;
        this.tipoVehiculo = tipoVehiculo;
    }
    
    public void Actualizar(string matricula, int TipoVehiculo)
    {
        this.matricula = matricula;
        this.tipoVehiculo = (TipoVehiculo)tipoVehiculo;
    }
}