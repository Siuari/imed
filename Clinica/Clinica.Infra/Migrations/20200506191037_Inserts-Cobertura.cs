using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class InsertsCobertura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT INTO ""Clinica"".""Cobertura""
                    (""Cob_IdCobertura"", ""Cob_Descricao"")
                values
                    ('4217d308-fc1a-4525-9313-c15dc8326a6c', 'PLANO DE SAÚDE'),
                    ('b00d3484-f30a-4f42-94b2-6b6ef24bce79', 'PARTICULAR'); 
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM ""Clinica"".""Cobertura""");
        }
    }
}
