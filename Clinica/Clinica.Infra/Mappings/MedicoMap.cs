using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Med_IdMedico");
            builder.Property(x => x.IdEspecialidade).HasColumnName("Esp_IdEspecialidade");
            builder.Property(x => x.Nome).HasColumnName("Med_Nome");
            builder.Property(x => x.Crm).HasColumnName("Med_Crm");

            builder.HasOne<Especialidade>()
                .WithMany(x => x.Medicos)
                .HasForeignKey(x => x.IdEspecialidade);

            builder.HasMany<HorarioAtendimento>()
                .WithOne(x => x.Medico)
                .HasForeignKey(x => x.IdMedico);

            builder.ToTable("Medico", "Clinica");
        }
    }
}
