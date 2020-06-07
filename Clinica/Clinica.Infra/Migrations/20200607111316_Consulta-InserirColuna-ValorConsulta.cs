using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class ConsultaInserirColunaValorConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Con_ValorConsulta",
                schema: "Clinica",
                table: "Consulta",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Con_ValorConsulta",
                schema: "Clinica",
                table: "Consulta");
        }
    }
}
