using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class tabelausuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Clinica",
                columns: table => new
                {
                    Usu_IdUsuario = table.Column<Guid>(nullable: false),
                    Usu_Login = table.Column<string>(nullable: true),
                    Usu_Senha = table.Column<string>(nullable: true),
                    Usu_IdPaciente = table.Column<Guid>(nullable: false),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Usu_IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Paciente_Usu_IdPaciente",
                        column: x => x.Usu_IdPaciente,
                        principalSchema: "Clinica",
                        principalTable: "Paciente",
                        principalColumn: "Pac_IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usu_IdPaciente",
                schema: "Clinica",
                table: "Usuario",
                column: "Usu_IdPaciente",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Clinica");
        }
    }
}
