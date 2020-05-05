using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class ReceitaMedicaMap : IEntityTypeConfiguration<ReceitaMedica>
    {
        public void Configure(EntityTypeBuilder<ReceitaMedica> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Rem_IdReceitaMedica");
            builder.Property(x => x.IdConsulta).HasColumnName("Con_IdConsulta");
            builder.Property(x => x.Descricao).HasColumnName("Rem_Descricao");
            builder.Property(x => x.DataEmissao).HasColumnName("Rem_DataEmissao");

            builder.HasOne<Consulta>()
                .WithMany(x => x.ReceitasMedica)
                .HasForeignKey(x => x.IdConsulta);

            builder.ToTable("ReceitaMedica", "Clinica");
        }
    }
}
