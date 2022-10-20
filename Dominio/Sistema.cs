namespace Dominio;
public class Sistema
{
    public list<Usuario> Usuarios;
    public list<ticketEstacionamiento> Tickets;
    public Estacionamiento estacionamiento;
    public PortalAsistenteEstacionamiento portalAsistenteEstacionamiento;
    public PortalInformacionCliente portalInformacionCliente;
    public PanelElectrico panelElectrico;

    public Sistema()
    {
        this.Usuarios = new list<Usuario>();
        this.Tickets = new list<ticketEstacionamiento>();
        this.portalAsistenteEstacionamiento = new PortalAsistenteEstacionamiento();
        this.portalInformacionCliente = new portalInformacionCliente();
        this.panelElectrico = new PanelElectrico();
    }
    public void CrearUsuario(string nombre, string contraseña) => this.Usuarios.Add(new Usuario(nombre, contraseña));

    public void EliminarUsuario(string nombre, string contraseña)
    {
        var usuario = this.Usuarios.SingleOrDefault(x => x.contraseña == contraseña);

        if (usuario is null)

            throw new Exception($"No existe usuario con id:{contraseña}");

        this.Usuarios.Remove(usuario);
    }

    public void emitirTicket() => System.Console.WriteLine();



}
