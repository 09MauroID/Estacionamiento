using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Persistencia
{
    public partial class UnNuevoCambio16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    tipoPago = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    montodePago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PanelElectrico",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelElectrico", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Panelentrada",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ubicacion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panelentrada", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PanelEstacionamento",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    espacioslibres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelEstacionamento", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PortalAsistenteEstacionamiento",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalAsistenteEstacionamiento", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contraseña = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    matricula = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipoVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.matricula);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TicketEntrada",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    matricula = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipoVehiculo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    horarioIngreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    PanelEntradaid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketEntrada", x => x.id);
                    table.ForeignKey(
                        name: "FK_TicketEntrada_Panelentrada_PanelEntradaid",
                        column: x => x.PanelEntradaid,
                        principalTable: "Panelentrada",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contraseña = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuarioid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.id);
                    table.ForeignKey(
                        name: "FK_Administrador_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ticketEntradaid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cliente_TicketEntrada_ticketEntradaid",
                        column: x => x.ticketEntradaid,
                        principalTable: "TicketEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PanelSalida",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TicketSalidaid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PagoTicket = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelSalida", x => x.id);
                    table.ForeignKey(
                        name: "FK_PanelSalida_TicketEntrada_TicketSalidaid",
                        column: x => x.TicketSalidaid,
                        principalTable: "TicketEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PortalInformacionCliente",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TicketSalida = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PagoTicket = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ticketEntradaid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalInformacionCliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_PortalInformacionCliente_TicketEntrada_ticketEntradaid",
                        column: x => x.ticketEntradaid,
                        principalTable: "TicketEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Asistente",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contrasenia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuarioid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Administradorid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PortalAsistenteEstacionamientoid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Asistente_Administrador_Administradorid",
                        column: x => x.Administradorid,
                        principalTable: "Administrador",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Asistente_PortalAsistenteEstacionamiento_PortalAsistenteEsta~",
                        column: x => x.PortalAsistenteEstacionamientoid,
                        principalTable: "PortalAsistenteEstacionamiento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Asistente_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    nroPiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    habilitado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Administradorid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.nroPiso);
                    table.ForeignKey(
                        name: "FK_Planta_Administrador_Administradorid",
                        column: x => x.Administradorid,
                        principalTable: "Administrador",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estacionamiento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    plantanroPiso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estacionamiento_Planta_plantanroPiso",
                        column: x => x.plantanroPiso,
                        principalTable: "Planta",
                        principalColumn: "nroPiso",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Slot",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    tipoSlot = table.Column<int>(type: "int", nullable: false),
                    tipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    Administradorid = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PlantanroPiso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.id);
                    table.ForeignKey(
                        name: "FK_Slot_Administrador_Administradorid",
                        column: x => x.Administradorid,
                        principalTable: "Administrador",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Slot_Planta_PlantanroPiso",
                        column: x => x.PlantanroPiso,
                        principalTable: "Planta",
                        principalColumn: "nroPiso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_usuarioid",
                table: "Administrador",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Asistente_Administradorid",
                table: "Asistente",
                column: "Administradorid");

            migrationBuilder.CreateIndex(
                name: "IX_Asistente_PortalAsistenteEstacionamientoid",
                table: "Asistente",
                column: "PortalAsistenteEstacionamientoid");

            migrationBuilder.CreateIndex(
                name: "IX_Asistente_usuarioid",
                table: "Asistente",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ticketEntradaid",
                table: "Cliente",
                column: "ticketEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_Estacionamiento_plantanroPiso",
                table: "Estacionamiento",
                column: "plantanroPiso");

            migrationBuilder.CreateIndex(
                name: "IX_PanelSalida_TicketSalidaid",
                table: "PanelSalida",
                column: "TicketSalidaid");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_Administradorid",
                table: "Planta",
                column: "Administradorid");

            migrationBuilder.CreateIndex(
                name: "IX_PortalInformacionCliente_ticketEntradaid",
                table: "PortalInformacionCliente",
                column: "ticketEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_Administradorid",
                table: "Slot",
                column: "Administradorid");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_PlantanroPiso",
                table: "Slot",
                column: "PlantanroPiso");

            migrationBuilder.CreateIndex(
                name: "IX_TicketEntrada_PanelEntradaid",
                table: "TicketEntrada",
                column: "PanelEntradaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistente");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Estacionamiento");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "PanelElectrico");

            migrationBuilder.DropTable(
                name: "PanelEstacionamento");

            migrationBuilder.DropTable(
                name: "PanelSalida");

            migrationBuilder.DropTable(
                name: "PortalInformacionCliente");

            migrationBuilder.DropTable(
                name: "Slot");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "PortalAsistenteEstacionamiento");

            migrationBuilder.DropTable(
                name: "TicketEntrada");

            migrationBuilder.DropTable(
                name: "Planta");

            migrationBuilder.DropTable(
                name: "Panelentrada");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
