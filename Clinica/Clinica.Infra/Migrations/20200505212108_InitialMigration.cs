using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Infra.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Clinica");

            migrationBuilder.CreateTable(
                name: "Cobertura",
                schema: "Clinica",
                columns: table => new
                {
                    Cob_IdCobertura = table.Column<Guid>(nullable: false),
                    Cob_Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.Cob_IdCobertura);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                schema: "Clinica",
                columns: table => new
                {
                    End_IdEndereco = table.Column<Guid>(nullable: false),
                    End_Rua = table.Column<string>(name: "End_Rua ", nullable: true),
                    End_Bairro = table.Column<string>(nullable: true),
                    End_Numero = table.Column<string>(nullable: true),
                    End_Cep = table.Column<string>(fixedLength: true, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.End_IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                schema: "Clinica",
                columns: table => new
                {
                    Esp_IdEspecialidade = table.Column<Guid>(nullable: false),
                    Esp_Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Esp_IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                schema: "Clinica",
                columns: table => new
                {
                    Fop_IdFormaPagamento = table.Column<Guid>(nullable: false),
                    Fop_Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Fop_IdFormaPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                schema: "Clinica",
                columns: table => new
                {
                    Hor_IdHorario = table.Column<Guid>(nullable: false),
                    Hor_HoraInicio = table.Column<string>(maxLength: 5, nullable: true),
                    Hor_Dia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Hor_IdHorario);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                schema: "Clinica",
                columns: table => new
                {
                    Pac_IdPaciente = table.Column<Guid>(nullable: false),
                    End_IdEndereco = table.Column<Guid>(nullable: false),
                    Pac_Nome = table.Column<string>(nullable: true),
                    Pac_DataNascimento = table.Column<DateTime>(nullable: false),
                    Pac_Telefone = table.Column<string>(nullable: true),
                    Pac_Rg = table.Column<string>(nullable: true),
                    Pac_Cpf = table.Column<string>(nullable: true),
                    EnderecoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Pac_IdPaciente);
                    table.ForeignKey(
                        name: "FK_Paciente_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalSchema: "Clinica",
                        principalTable: "Endereco",
                        principalColumn: "End_IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paciente_Endereco_End_IdEndereco",
                        column: x => x.End_IdEndereco,
                        principalSchema: "Clinica",
                        principalTable: "Endereco",
                        principalColumn: "End_IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                schema: "Clinica",
                columns: table => new
                {
                    Med_IdMedico = table.Column<Guid>(nullable: false),
                    Esp_IdEspecialidade = table.Column<Guid>(nullable: false),
                    Med_Nome = table.Column<string>(nullable: true),
                    Med_Crm = table.Column<string>(nullable: true),
                    EspecialidadeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Med_IdMedico);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalSchema: "Clinica",
                        principalTable: "Especialidade",
                        principalColumn: "Esp_IdEspecialidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_Esp_IdEspecialidade",
                        column: x => x.Esp_IdEspecialidade,
                        principalSchema: "Clinica",
                        principalTable: "Especialidade",
                        principalColumn: "Esp_IdEspecialidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorarioAtendimento",
                schema: "Clinica",
                columns: table => new
                {
                    Hoa_IdHorarioAtendimento = table.Column<Guid>(nullable: false),
                    Med_IdMedico = table.Column<Guid>(nullable: false),
                    Hor_IdHorario = table.Column<Guid>(nullable: false),
                    MedicoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioAtendimento", x => x.Hoa_IdHorarioAtendimento);
                    table.ForeignKey(
                        name: "FK_HorarioAtendimento_Horario_Hor_IdHorario",
                        column: x => x.Hor_IdHorario,
                        principalSchema: "Clinica",
                        principalTable: "Horario",
                        principalColumn: "Hor_IdHorario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioAtendimento_Horario_Med_IdMedico",
                        column: x => x.Med_IdMedico,
                        principalSchema: "Clinica",
                        principalTable: "Horario",
                        principalColumn: "Hor_IdHorario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioAtendimento_Medico_Med_IdMedico",
                        column: x => x.Med_IdMedico,
                        principalSchema: "Clinica",
                        principalTable: "Medico",
                        principalColumn: "Med_IdMedico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorarioAtendimento_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalSchema: "Clinica",
                        principalTable: "Medico",
                        principalColumn: "Med_IdMedico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                schema: "Clinica",
                columns: table => new
                {
                    Con_IdConsulta = table.Column<Guid>(nullable: false),
                    Pac_IdPaciente = table.Column<Guid>(nullable: false),
                    Cob_IdCobertura = table.Column<Guid>(nullable: false),
                    Hoa_IdHorarioAtendimento = table.Column<Guid>(nullable: false),
                    Con_Data = table.Column<DateTime>(nullable: false),
                    HorarioAtendimentoId = table.Column<Guid>(nullable: true),
                    PacienteId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.Con_IdConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_HorarioAtendimento_HorarioAtendimentoId",
                        column: x => x.HorarioAtendimentoId,
                        principalSchema: "Clinica",
                        principalTable: "HorarioAtendimento",
                        principalColumn: "Hoa_IdHorarioAtendimento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_Cobertura_Cob_IdCobertura",
                        column: x => x.Cob_IdCobertura,
                        principalSchema: "Clinica",
                        principalTable: "Cobertura",
                        principalColumn: "Cob_IdCobertura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_HorarioAtendimento_Hoa_IdHorarioAtendimento",
                        column: x => x.Hoa_IdHorarioAtendimento,
                        principalSchema: "Clinica",
                        principalTable: "HorarioAtendimento",
                        principalColumn: "Hoa_IdHorarioAtendimento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_Pac_IdPaciente",
                        column: x => x.Pac_IdPaciente,
                        principalSchema: "Clinica",
                        principalTable: "Paciente",
                        principalColumn: "Pac_IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalSchema: "Clinica",
                        principalTable: "Paciente",
                        principalColumn: "Pac_IdPaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                schema: "Clinica",
                columns: table => new
                {
                    Pag_IdPagamento = table.Column<Guid>(nullable: false),
                    Con_IdConsulta = table.Column<Guid>(nullable: false),
                    Fop_IdFormaPagamento = table.Column<Guid>(nullable: false),
                    Pag_Valor = table.Column<decimal>(nullable: false),
                    Pag_DataPagamento = table.Column<DateTime>(nullable: false),
                    ConsultaId = table.Column<Guid>(nullable: true),
                    FormaPagamentoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Pag_IdPagamento);
                    table.ForeignKey(
                        name: "FK_Pagamento_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamento_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalSchema: "Clinica",
                        principalTable: "FormaPagamento",
                        principalColumn: "Fop_IdFormaPagamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamento_Consulta_Con_IdConsulta",
                        column: x => x.Con_IdConsulta,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamento_FormaPagamento_Fop_IdFormaPagamento",
                        column: x => x.Fop_IdFormaPagamento,
                        principalSchema: "Clinica",
                        principalTable: "FormaPagamento",
                        principalColumn: "Fop_IdFormaPagamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaMedica",
                schema: "Clinica",
                columns: table => new
                {
                    Rem_IdReceitaMedica = table.Column<Guid>(nullable: false),
                    Con_IdConsulta = table.Column<Guid>(nullable: false),
                    Rem_Descricao = table.Column<string>(nullable: true),
                    Rem_DataEmissao = table.Column<DateTime>(nullable: false),
                    ConsultaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaMedica", x => x.Rem_IdReceitaMedica);
                    table.ForeignKey(
                        name: "FK_ReceitaMedica_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceitaMedica_Consulta_Con_IdConsulta",
                        column: x => x.Con_IdConsulta,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequerimentoExame",
                schema: "Clinica",
                columns: table => new
                {
                    Ree_IdRequerimentoExames = table.Column<Guid>(nullable: false),
                    Con_IdConsulta = table.Column<Guid>(nullable: false),
                    Ree_Descricao = table.Column<string>(nullable: true),
                    Ree_DataEmissao = table.Column<DateTime>(nullable: false),
                    ConsultaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequerimentoExame", x => x.Ree_IdRequerimentoExames);
                    table.ForeignKey(
                        name: "FK_RequerimentoExame_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequerimentoExame_Consulta_Con_IdConsulta",
                        column: x => x.Con_IdConsulta,
                        principalSchema: "Clinica",
                        principalTable: "Consulta",
                        principalColumn: "Con_IdConsulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_HorarioAtendimentoId",
                schema: "Clinica",
                table: "Consulta",
                column: "HorarioAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_Cob_IdCobertura",
                schema: "Clinica",
                table: "Consulta",
                column: "Cob_IdCobertura");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_Hoa_IdHorarioAtendimento",
                schema: "Clinica",
                table: "Consulta",
                column: "Hoa_IdHorarioAtendimento");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_Pac_IdPaciente",
                schema: "Clinica",
                table: "Consulta",
                column: "Pac_IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                schema: "Clinica",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_Hor_IdHorario",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Hor_IdHorario");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_Med_IdMedico",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "Med_IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAtendimento_MedicoId",
                schema: "Clinica",
                table: "HorarioAtendimento",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadeId",
                schema: "Clinica",
                table: "Medico",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_Esp_IdEspecialidade",
                schema: "Clinica",
                table: "Medico",
                column: "Esp_IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_EnderecoId",
                schema: "Clinica",
                table: "Paciente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_End_IdEndereco",
                schema: "Clinica",
                table: "Paciente",
                column: "End_IdEndereco");

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
                name: "IX_Pagamento_Con_IdConsulta",
                schema: "Clinica",
                table: "Pagamento",
                column: "Con_IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_Fop_IdFormaPagamento",
                schema: "Clinica",
                table: "Pagamento",
                column: "Fop_IdFormaPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaMedica_ConsultaId",
                schema: "Clinica",
                table: "ReceitaMedica",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaMedica_Con_IdConsulta",
                schema: "Clinica",
                table: "ReceitaMedica",
                column: "Con_IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_RequerimentoExame_ConsultaId",
                schema: "Clinica",
                table: "RequerimentoExame",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_RequerimentoExame_Con_IdConsulta",
                schema: "Clinica",
                table: "RequerimentoExame",
                column: "Con_IdConsulta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "ReceitaMedica",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "RequerimentoExame",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "FormaPagamento",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Consulta",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "HorarioAtendimento",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Cobertura",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Paciente",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Horario",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Medico",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Endereco",
                schema: "Clinica");

            migrationBuilder.DropTable(
                name: "Especialidade",
                schema: "Clinica");
        }
    }
}
