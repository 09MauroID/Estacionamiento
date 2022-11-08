namespace Dominio;

public class Estacionamiento
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public Planta planta { get; set; }

    public Estacionamiento(string Nombre, string Direccion, Planta planta)
    {
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.planta = planta;

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}
