namespace Dominio.src;

public class Planta
{
    public int nroPiso { get; set; }
    public List<Slot> slots { get; set; }
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