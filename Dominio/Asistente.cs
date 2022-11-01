namespace Dominio;

public class Asistente
{
    public Guid id ;
    public string? nombre ;
    public string? contrasenia ;

    public Asistente ( Guid id, string nombre, string contrasenia)
    {
       this.id= id ;
       this.nombre = nombre;
       this.contrasenia= contrasenia; 
    }

}
