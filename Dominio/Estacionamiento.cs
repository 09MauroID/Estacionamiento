namespace Dominio;

public class Estacionamiento
{
    public string? nombre;
    public string? Direccion;
    public Planta plantasdeEstacionamiento;

    public Estacionamiento(string nombre, string Direccion)
    {
        this.nombre = nombre;
        this.Direccion = Direccion;
        this.plantasdeEstacionamiento = new Planta();

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}
