using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Persistencia.Migraciones
{
    public partial class UnCambioNuevo99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "contrasenia",
                table: "Asistente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "usuarioid",
                table: "Asistente",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Asistente_usuarioid",
                table: "Asistente",
                column: "usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistente_Usuario_usuarioid",
                table: "Asistente",
                column: "usuarioid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistente_Usuario_usuarioid",
                table: "Asistente");

            migrationBuilder.DropIndex(
                name: "IX_Asistente_usuarioid",
                table: "Asistente");

            migrationBuilder.DropColumn(
                name: "usuarioid",
                table: "Asistente");

            migrationBuilder.UpdateData(
                table: "Asistente",
                keyColumn: "contrasenia",
                keyValue: null,
                column: "contrasenia",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "contrasenia",
                table: "Asistente",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
