using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio.src;
[Table("Planta")]
public class Planta
{
    [Key]
    [Required]
    public int nroPiso { get; set; }
    public List<Slot> slots { get; set; }
    [Required]
    public bool habilitado { get; set; } = false;

    public Planta(int nroPiso)
    {
        this.nroPiso = nroPiso;
        this.slots = new List<Slot>();

    }

    public void AgregarSlot(Slot slot) => this.slots.Add(slot);

    public void Habilitar()
    {
        if (!habilitado)
            this.habilitado = true;
    }

    public void Deshabilitar()
    {
        if (habilitado == true)
            this.habilitado = false;
    }
}