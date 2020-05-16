using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class AjustesColunasForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_HorarioAtendimento_HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Paciente_PacienteId",
                schema: "Clinica",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_HorarioAtendimento_Horario_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_HorarioAtendimento_Medico_MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Especialidade_EspecialidadeId",
                schema: "Clinica",
                table: "Medico");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Endereco_EnderecoId",
                schema: "Clinica",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Consulta_ConsultaId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_FormaPagamento_FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaMedica_Consulta_ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica");

            migrationBuilder.DropForeignKey(
                name: "FK_RequerimentoExame_Consulta_ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame");

            migrationBuilder.DropIndex(
                name: "IX_RequerimentoExame_ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame");

            migrationBuilder.DropIndex(
                name: "IX_ReceitaMedica_ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_ConsultaId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_EnderecoId",
                schema: "Clinica",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Medico_EspecialidadeId",
                schema: "Clinica",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_HorarioAtendimento_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropIndex(
                name: "IX_HorarioAtendimento_MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta");

            migrationBuilder.DropIndex(
                name: "IX_Consulta_PacienteId",
                schema: "Clinica",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame");

            migrationBuilder.DropColumn(
                name: "ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica");

            migrationBuilder.DropColumn(
                name: "ConsultaId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                schema: "Clinica",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                schema: "Clinica",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento");

            migrationBuilder.DropColumn(
                name: "HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                schema: "Clinica",
                table: "Consulta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultaId",
                schema: "Clinica",
                table: "Pagamento",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EnderecoId",
                schema: "Clinica",
                table: "Paciente",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EspecialidadeId",
                schema: "Clinica",
                table: "Medico",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PacienteId",
                schema: "Clinica",
                table: "Consulta",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequerimentoExame_ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaMedica_ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ConsultaId",
                schema: "Clinica",
                table: "Pagamento",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_EnderecoId",
                schema: "Clinica",
                table: "Paciente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadeId",
                schema: "Clinica",
                table: "Medico",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Hor_IdHorario");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta",
                column: "HorarioAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                schema: "Clinica",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_HorarioAtendimento_HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta",
                column: "HorarioAtendimentoId",
                principalSchema: "Clinica",
                principalTable: "HorarioAtendimento",
                principalColumn: "Hoa_IdHorarioAtendimento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Paciente_PacienteId",
                schema: "Clinica",
                table: "Consulta",
                column: "PacienteId",
                principalSchema: "Clinica",
                principalTable: "Paciente",
                principalColumn: "Pac_IdPaciente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioAtendimento_Horario_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Hor_IdHorario",
                principalSchema: "Clinica",
                principalTable: "Horario",
                principalColumn: "Hor_IdHorario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioAtendimento_Medico_MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "MedicoId",
                principalSchema: "Clinica",
                principalTable: "Medico",
                principalColumn: "Med_IdMedico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Especialidade_EspecialidadeId",
                schema: "Clinica",
                table: "Medico",
                column: "EspecialidadeId",
                principalSchema: "Clinica",
                principalTable: "Especialidade",
                principalColumn: "Esp_IdEspecialidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Endereco_EnderecoId",
                schema: "Clinica",
                table: "Paciente",
                column: "EnderecoId",
                principalSchema: "Clinica",
                principalTable: "Endereco",
                principalColumn: "End_IdEndereco",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Consulta_ConsultaId",
                schema: "Clinica",
                table: "Pagamento",
                column: "ConsultaId",
                principalSchema: "Clinica",
                principalTable: "Consulta",
                principalColumn: "Con_IdConsulta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_FormaPagamento_FormaPagamentoId",
                schema: "Clinica",
                table: "Pagamento",
                column: "FormaPagamentoId",
                principalSchema: "Clinica",
                principalTable: "FormaPagamento",
                principalColumn: "Fop_IdFormaPagamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceitaMedica_Consulta_ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica",
                column: "ConsultaId",
                principalSchema: "Clinica",
                principalTable: "Consulta",
                principalColumn: "Con_IdConsulta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequerimentoExame_Consulta_ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame",
                column: "ConsultaId",
                principalSchema: "Clinica",
                principalTable: "Consulta",
                principalColumn: "Con_IdConsulta",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
