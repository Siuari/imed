using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Pac_IdPaciente");
            builder.Property(x => x.IdEndereco).HasColumnName("End_IdEndereco");
            builder.Property(x => x.Nome).HasColumnName("Pac_Nome");
            builder.Property(x => x.DateNascimento).HasColumnName("Pac_DataNascimento");
            builder.Property(x => x.NumeroTelefone).HasColumnName("Pac_Telefone");
            builder.Property(x => x.Rg).HasColumnName("Pac_Rg");
            builder.Property(x => x.Cpf).HasColumnName("Pac_Cpf");

            builder.HasOne<Endereco>()
                .WithMany(x => x.Pacientes)
                .HasForeignKey(x => x.IdEndereco);

            builder.HasMany<Consulta>()
                .WithOne(x => x.Paciente)
                .HasForeignKey(x => x.IdPaciente);

            builder.ToTable("Paciente", "Clinica");
        }
    }
}
