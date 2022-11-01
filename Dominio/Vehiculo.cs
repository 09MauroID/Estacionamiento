namespace Dominio;

public class Vehiculo
{
    public bool automovil;
    public  bool camion;
    public bool electrico; 
    public bool camioneta; 
    public bool motocicleta;

    public Vehiculo(bool automovil, bool camion, bool electrico, bool camioneta, bool motocicleta)
    {
        this.automovil = automovil;
        this.camion = camion;
        this.electrico = electrico;
        this.camioneta = camioneta;
        this.motocicleta = motocicleta; 
    }
}
