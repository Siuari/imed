using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class InsertsParciaisHorario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"INSERT INTO ""Clinica"".""Horario""
                (""Hor_IdHorario"", ""Hor_HoraInicio"", ""Hor_Dia"")
            values
                ('86c848a6-16d7-4449-b8af-96d04064be88', '07:00', 2),
            ('56f64620-c21e-4ea6-aaab-4300ccc2ded2', '08:00', 2),
            ('2ddb8776-b467-429f-b7e4-dde3dc3562a1', '09:00', 2),
            ('77d87233-7954-46c4-87fc-93a00e9bd858', '14:00', 2),
            ('bea652b1-2309-41b7-b7a9-9122902e7ad3', '15:00', 2),
            ('e6261259-d3d3-42ba-851e-a793cdf17e6e', '16:00', 2),
            ('552601ac-6b79-4d0c-892a-34a0d28477a1', '07:00', 3),
            ('a7fbbe0b-8afc-4f56-8e0f-18a3901bae33', '08:00', 3),
            ('0c562151-e503-48a6-8d70-fe2e911f8a8a', '09:00', 3),
            ('65e49aea-6dc3-4dd6-9a6c-99739e5763c3', '14:00', 3),
            ('2b3d7902-2e66-42be-8faf-4a559eff85af', '15:00', 3),
            ('13817a20-9598-49b9-aaf6-12fdeef1aad0', '16:00', 3);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM ""Clinica"".""Horario""");
        }
    }
}
