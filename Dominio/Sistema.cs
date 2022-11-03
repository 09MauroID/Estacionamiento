namespace Dominio;

public class Sistema
{
    public List<Usuario> Usuarios { get; set; }
    public List<TicketEntrada> Tickets { get; set; }
    public List<Administrador> administradores { get; set; }
    public Estacionamiento estacionamiento { get; set; }
    public PortalAsistenteEstacionamiento portalAsistenteEstacionamiento { get; set; }
    public PortalInformacionCliente portalInformacionCliente { get; set; }
    public PanelElectrico panelElectrico { get; set; }

    public Sistema()
    {
        this.Usuarios = new List<Usuario>();
        this.Tickets = new List<TicketEntrada>();
        this.administradores = new List<Administrador>();
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
