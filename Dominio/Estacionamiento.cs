namespace Dominio;

public class Estacionamiento
{
    public string nombre ;
    public string Direccion;
    public PlantasdeEstacionamiento plantasdeEstacionamiento;

    public Estacionamiento (string nombre, string Direccion)
    {
        this.nombre = nombre;
        this.Direccion = Direccion;

    }

    // este metodo no sirve pa mas nada que adornopublic void estacionamiento()
}
