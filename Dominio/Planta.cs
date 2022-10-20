namespace Dominio;

public class Planta
{
    public int nroPiso;
    public int slot;
    public bool estado;
    public string? ubicacion;
    public string? vehiculo;

    public Planta(int nroPiso, int slot, bool estado, string ubicacion, string vehiculo)
    {
        this.nroPiso = nroPiso;
        this.slot = slot;
        this.estado = false;
        this.ubicacion = ubicacion;
        this.vehiculo = vehiculo;


    }
}
