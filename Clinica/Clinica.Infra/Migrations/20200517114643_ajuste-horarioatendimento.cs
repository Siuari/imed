using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class ajustehorarioatendimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorarioAtendimento_Horario_Med_IdMedico",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Hor_IdHorario");

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioAtendimento_Horario_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Hor_IdHorario",
                principalSchema: "Clinica",
                principalTable: "Horario",
                principalColumn: "Hor_IdHorario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorarioAtendimento_Horario_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropIndex(
                name: "IX_HorarioAtendimento_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioAtendimento_Horario_Med_IdMedico",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Med_IdMedico",
                principalSchema: "Clinica",
                principalTable: "Horario",
                principalColumn: "Hor_IdHorario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
