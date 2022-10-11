namespace Dominio;
public class Sistema
{
    public list<Usuario> Usuarios ;
    public list<Ticket> Tickets ;
    public Estacionamiento estacionamiento;
    public PortalAsistenteEstacionamiento portalAsistenteEstacionamiento;
    public PortalInformacionCliente portalInformacionCliente;
    public PanelElectrico panelElectrico;

    public Sistema ()
    {
        this.Usuarios = new list<Usuario>();
        this.Tickets = new list<Ticket>();
        this.portalAsistenteEstacionamiento = new PortalAsistenteEstacionamiento();
        this.portalInformacionCliente = new portalInformacionCliente();
        this.panelElectrico = new PanelElectrico();
    }
    public void CrearUsuario(string nombre, string contraseña)=> this.Usuarios.Add(new Usuario(nombre,contraseña));

    public void EliminarUsuario(string nombre, string contraseña)
    {
        var usuario = this.Usuarios.SingleOrDefault(x => x.id ==  id);

        if (usuario is null)

            throw new Exeption($"No existe usuario con id:{id}");

        this.Usuarios.Remove(usuario);
    }

    public void emitirTicket () => 



}
