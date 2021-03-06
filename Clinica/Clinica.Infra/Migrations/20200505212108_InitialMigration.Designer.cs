﻿// <auto-generated />
using System;
using Clinica.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Clinica.Infra.Migrations
{
    [DbContext(typeof(ClinicaContext))]
    [Migration("20200505212108_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Clinica.Domain.Models.Cobertura", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Cob_IdCobertura")
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .HasColumnName("Cob_Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cobertura","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Consulta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Con_IdConsulta")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnName("Con_Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("HorarioAtendimentoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCobertura")
                        .HasColumnName("Cob_IdCobertura")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdHorarioAtendimento")
                        .HasColumnName("Hoa_IdHorarioAtendimento")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnName("Pac_IdPaciente")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PacienteId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("HorarioAtendimentoId");

                    b.HasIndex("IdCobertura");

                    b.HasIndex("IdHorarioAtendimento");

                    b.HasIndex("IdPaciente");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consulta","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Endereco", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("End_IdEndereco")
                        .HasColumnType("uuid");

                    b.Property<string>("Bairro")
                        .HasColumnName("End_Bairro")
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .HasColumnName("End_Cep")
                        .HasColumnType("character(8)")
                        .IsFixedLength(true)
                        .HasMaxLength(8);

                    b.Property<string>("Numero")
                        .HasColumnName("End_Numero")
                        .HasColumnType("text");

                    b.Property<string>("Rua")
                        .HasColumnName("End_Rua ")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Endereco","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Especialidade", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Esp_IdEspecialidade")
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .HasColumnName("Esp_Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Especialidade","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.FormaPagamento", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Fop_IdFormaPagamento")
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .HasColumnName("Fop_Descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Horario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Hor_IdHorario")
                        .HasColumnType("uuid");

                    b.Property<int>("Dia")
                        .HasColumnName("Hor_Dia")
                        .HasColumnType("integer");

                    b.Property<string>("HoraInicio")
                        .HasColumnName("Hor_HoraInicio")
                        .HasColumnType("character varying(5)")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Horario","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.HorarioAtendimento", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Hoa_IdHorarioAtendimento")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdHorario")
                        .HasColumnName("Hor_IdHorario")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdMedico")
                        .HasColumnName("Med_IdMedico")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MedicoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdHorario");

                    b.HasIndex("IdMedico");

                    b.HasIndex("MedicoId");

                    b.ToTable("HorarioAtendimento","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Medico", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Med_IdMedico")
                        .HasColumnType("uuid");

                    b.Property<string>("Crm")
                        .HasColumnName("Med_Crm")
                        .HasColumnType("text");

                    b.Property<Guid?>("EspecialidadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdEspecialidade")
                        .HasColumnName("Esp_IdEspecialidade")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnName("Med_Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("IdEspecialidade");

                    b.ToTable("Medico","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Pac_IdPaciente")
                        .HasColumnType("uuid");

                    b.Property<string>("Cpf")
                        .HasColumnName("Pac_Cpf")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateNascimento")
                        .HasColumnName("Pac_DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdEndereco")
                        .HasColumnName("End_IdEndereco")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnName("Pac_Nome")
                        .HasColumnType("text");

                    b.Property<string>("NumeroTelefone")
                        .HasColumnName("Pac_Telefone")
                        .HasColumnType("text");

                    b.Property<string>("Rg")
                        .HasColumnName("Pac_Rg")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Paciente","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Pagamento", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Pag_IdPagamento")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ConsultaId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnName("Pag_DataPagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("FormaPagamentoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnName("Con_IdConsulta")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdFormaPagamento")
                        .HasColumnName("Fop_IdFormaPagamento")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Valor")
                        .HasColumnName("Pag_Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("IdConsulta");

                    b.HasIndex("IdFormaPagamento");

                    b.ToTable("Pagamento","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.ReceitaMedica", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Rem_IdReceitaMedica")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ConsultaId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnName("Rem_DataEmissao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnName("Rem_Descricao")
                        .HasColumnType("text");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnName("Con_IdConsulta")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.HasIndex("IdConsulta");

                    b.ToTable("ReceitaMedica","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.RequerimentoExame", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Ree_IdRequerimentoExames")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ConsultaId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnName("Ree_DataEmissao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasColumnName("Ree_Descricao")
                        .HasColumnType("text");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnName("Con_IdConsulta")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.HasIndex("IdConsulta");

                    b.ToTable("RequerimentoExame","Clinica");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Consulta", b =>
                {
                    b.HasOne("Clinica.Domain.Models.HorarioAtendimento", null)
                        .WithMany("Consultas")
                        .HasForeignKey("HorarioAtendimentoId");

                    b.HasOne("Clinica.Domain.Models.Cobertura", "Cobertura")
                        .WithMany("Consultas")
                        .HasForeignKey("IdCobertura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.HorarioAtendimento", "HorarioAtendimento")
                        .WithMany()
                        .HasForeignKey("IdHorarioAtendimento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.Paciente", null)
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId");
                });

            modelBuilder.Entity("Clinica.Domain.Models.HorarioAtendimento", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("IdHorario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.Horario", null)
                        .WithMany("HorariosAtendimento")
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.Medico", null)
                        .WithMany("HorariosAtendimento")
                        .HasForeignKey("MedicoId");
                });

            modelBuilder.Entity("Clinica.Domain.Models.Medico", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId");

                    b.HasOne("Clinica.Domain.Models.Especialidade", null)
                        .WithMany("Medicos")
                        .HasForeignKey("IdEspecialidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Domain.Models.Paciente", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Clinica.Domain.Models.Endereco", null)
                        .WithMany("Pacientes")
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Domain.Models.Pagamento", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaId");

                    b.HasOne("Clinica.Domain.Models.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId");

                    b.HasOne("Clinica.Domain.Models.Consulta", null)
                        .WithMany("Pagamentos")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Domain.Models.FormaPagamento", null)
                        .WithMany("Pagamentos")
                        .HasForeignKey("IdFormaPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Domain.Models.ReceitaMedica", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaId");

                    b.HasOne("Clinica.Domain.Models.Consulta", null)
                        .WithMany("ReceitasMedica")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Domain.Models.RequerimentoExame", b =>
                {
                    b.HasOne("Clinica.Domain.Models.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaId");

                    b.HasOne("Clinica.Domain.Models.Consulta", null)
                        .WithMany("RequerimentosExame")
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
