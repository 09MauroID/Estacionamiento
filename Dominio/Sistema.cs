namespace Dominio;

public class Sistema
{
    public List<Usuario> Usuarios;
    public List<TicketEntrada> Tickets;
    public Estacionamiento estacionamiento;
    public PortalAsistenteEstacionamiento portalAsistenteEstacionamiento;
    public PortalInformacionCliente portalInformacionCliente;
    public PanelElectrico panelElectrico;

    public Sistema()
    {
        this.Usuarios = new List<Usuario>();
        this.Tickets = new List<TicketEntrada>();
        this.portalAsistenteEstacionamiento = new PortalAsistenteEstacionamiento();
        this.portalInformacionCliente = new PortalInformacionCliente();
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
