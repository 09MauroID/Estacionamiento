namespace Dominio.src;

public class Planta
{
    public int nroPiso { get; set; }
    public List<Slot> slots { get; set; }
    public string? vehiculo { get; set; }
    public bool habilitado { get; set; } = false;

    public Planta(int nroPiso, string vehiculo)
    {
        this.nroPiso = nroPiso;
        this.slots = new List<Slot>();
        this.vehiculo = vehiculo;
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