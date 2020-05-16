using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class InsertsEspecialidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT INTO ""Clinica"".""Especialidade""
                    (""Esp_IdEspecialidade"", ""Esp_Descricao"")
                values
                    ('b62cee51-61f1-4be5-9eb3-ec6afd4e1318', 'ORTOPEDISTA'),
                    ('efb27a42-2511-44e2-a1e0-f8acde07eb7c', 'CLINICO GERAL'),
                    ('e527b6e9-d528-422a-8575-ccd6900ead93', 'DENTISTA');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM ""Clinica"".""Especialidade""");

        }
    }
}
