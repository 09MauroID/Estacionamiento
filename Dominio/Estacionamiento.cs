namespace Dominio;

public class Estacionamiento
{
    public string? Nombre;
    public string? Direccion;
    public Planta planta;

    public Estacionamiento(string Nombre, string Direccion, Planta planta)
    {
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.planta = new Planta;

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}
