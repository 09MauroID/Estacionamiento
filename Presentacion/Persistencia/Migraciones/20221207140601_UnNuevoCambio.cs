using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Persistencia.Migraciones
{
    public partial class UnNuevoCambio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrador_Sistema_Sistemaid",
                table: "Administrador");

            migrationBuilder.DropForeignKey(
                name: "FK_Panelentrada_TicketEntrada_ticketEntradaid",
                table: "Panelentrada");

            migrationBuilder.DropForeignKey(
                name: "FK_PortalAsistenteEstacionamiento_Sistema_sistemaid",
                table: "PortalAsistenteEstacionamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketEntrada_Sistema_Sistemaid",
                table: "TicketEntrada");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Sistema_Sistemaid",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Sistema");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_Sistemaid",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_PortalAsistenteEstacionamiento_sistemaid",
                table: "PortalAsistenteEstacionamiento");

            migrationBuilder.DropIndex(
                name: "IX_Panelentrada_ticketEntradaid",
                table: "Panelentrada");

            migrationBuilder.DropIndex(
                name: "IX_Administrador_Sistemaid",
                table: "Administrador");

            migrationBuilder.DropColumn(
                name: "Sistemaid",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "sistemaid",
                table: "PortalAsistenteEstacionamiento");

            migrationBuilder.DropColumn(
                name: "ticketEntradaid",
                table: "Panelentrada");

            migrationBuilder.DropColumn(
                name: "Sistemaid",
                table: "Administrador");

            migrationBuilder.RenameColumn(
                name: "Sistemaid",
                table: "TicketEntrada",
                newName: "PanelEntradaid");

            migrationBuilder.RenameIndex(
                name: "IX_TicketEntrada_Sistemaid",
                table: "TicketEntrada",
                newName: "IX_TicketEntrada_PanelEntradaid");

            migrationBuilder.RenameColumn(
                name: "TipoSlot",
                table: "Slot",
                newName: "tipoSlot");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketEntrada_Panelentrada_PanelEntradaid",
                table: "TicketEntrada",
                column: "PanelEntradaid",
                principalTable: "Panelentrada",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketEntrada_Panelentrada_PanelEntradaid",
                table: "TicketEntrada");

            migrationBuilder.RenameColumn(
                name: "PanelEntradaid",
                table: "TicketEntrada",
                newName: "Sistemaid");

            migrationBuilder.RenameIndex(
                name: "IX_TicketEntrada_PanelEntradaid",
                table: "TicketEntrada",
                newName: "IX_TicketEntrada_Sistemaid");

            migrationBuilder.RenameColumn(
                name: "tipoSlot",
                table: "Slot",
                newName: "TipoSlot");

            migrationBuilder.AddColumn<Guid>(
                name: "Sistemaid",
                table: "Usuario",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "sistemaid",
                table: "PortalAsistenteEstacionamiento",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ticketEntradaid",
                table: "Panelentrada",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "Sistemaid",
                table: "Administrador",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EstacionamientoId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PanelElectricoid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PortalInformacionClienteid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sistema_Estacionamiento_EstacionamientoId",
                        column: x => x.EstacionamientoId,
                        principalTable: "Estacionamiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sistema_PanelElectrico_PanelElectricoid",
                        column: x => x.PanelElectricoid,
                        principalTable: "PanelElectrico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sistema_PortalInformacionCliente_PortalInformacionClienteid",
                        column: x => x.PortalInformacionClienteid,
                        principalTable: "PortalInformacionCliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Sistemaid",
                table: "Usuario",
                column: "Sistemaid");

            migrationBuilder.CreateIndex(
                name: "IX_PortalAsistenteEstacionamiento_sistemaid",
                table: "PortalAsistenteEstacionamiento",
                column: "sistemaid");

            migrationBuilder.CreateIndex(
                name: "IX_Panelentrada_ticketEntradaid",
                table: "Panelentrada",
                column: "ticketEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_Sistemaid",
                table: "Administrador",
                column: "Sistemaid");

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_EstacionamientoId",
                table: "Sistema",
                column: "EstacionamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_PanelElectricoid",
                table: "Sistema",
                column: "PanelElectricoid");

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_PortalInformacionClienteid",
                table: "Sistema",
                column: "PortalInformacionClienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrador_Sistema_Sistemaid",
                table: "Administrador",
                column: "Sistemaid",
                principalTable: "Sistema",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Panelentrada_TicketEntrada_ticketEntradaid",
                table: "Panelentrada",
                column: "ticketEntradaid",
                principalTable: "TicketEntrada",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PortalAsistenteEstacionamiento_Sistema_sistemaid",
                table: "PortalAsistenteEstacionamiento",
                column: "sistemaid",
                principalTable: "Sistema",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketEntrada_Sistema_Sistemaid",
                table: "TicketEntrada",
                column: "Sistemaid",
                principalTable: "Sistema",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Sistema_Sistemaid",
                table: "Usuario",
                column: "Sistemaid",
                principalTable: "Sistema",
                principalColumn: "id");
        }
    }
}
