using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class AjusteConsultaColunaStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Con_StatusConsulta",
                schema: "Clinica",
                table: "Consulta",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Con_StatusConsulta",
                schema: "Clinica",
                table: "Consulta");
        }
    }
}
