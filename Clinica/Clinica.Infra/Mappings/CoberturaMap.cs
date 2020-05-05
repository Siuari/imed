using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class CoberturaMap : IEntityTypeConfiguration<Cobertura>
    {
        public void Configure(EntityTypeBuilder<Cobertura> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Cob_IdCobertura");
            builder.Property(x => x.Descricao).HasColumnName("Cob_Descricao");

            builder.HasMany(x => x.Consultas)
                .WithOne(x => x.Cobertura)
                .HasForeignKey(x => x.IdCobertura);

            builder.ToTable("Cobertura", "Clinica");
        }
    }
}
