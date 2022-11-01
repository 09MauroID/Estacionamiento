namespace Dominio;

public class Estacionamiento
{
    public string? nombre;
    public string? Direccion;
    public Planta planta;

    public Estacionamiento(string nombre, string Direccion)
    {
        this.nombre = nombre;
        this.Direccion = Direccion;
        this.planta = new Planta();

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}
