using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Esp_IdEspecialidade");
            builder.Property(x => x.Descricao).HasColumnName("Esp_Descricao");

            builder.HasMany(x => x.Medicos)
                .WithOne(x => x.Especialidade)
                .HasForeignKey(x => x.IdEspecialidade);

            builder.ToTable("Especialidade", "Clinica");
        }
    }
}
