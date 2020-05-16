using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class InsertsFormaDePagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT INTO ""Clinica"".""FormaPagamento""
                    (""Fop_IdFormaPagamento"", ""Fop_Descricao"")
                values
                    ('c62ab7eb-77ce-43df-b0c7-5fecf7a75ea7', 'CARTÃO DE CRÉDITO'),
                    ('3a83170f-b1f5-4fa8-8699-cd03cc4a9bfa', 'CARTÃO DE DÉBITO'),
                    ('03809cb1-56b2-4cdc-8d2b-1d3fb999648a', 'A VISTA'); "
           );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM ""Clinica"".""FormaPagamento""");
        }
    }
}
