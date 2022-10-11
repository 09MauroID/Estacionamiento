namespace Dominio;

public class Usuario
{
    public Guid id;
    public string nombre;
    public string contraseña;

    public Usuario (string nombre, string contraseña)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
    }
    

}
