using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class RequerimentoExameMap : IEntityTypeConfiguration<RequerimentoExame>
    {
        public void Configure(EntityTypeBuilder<RequerimentoExame> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Ree_IdRequerimentoExames");
            builder.Property(x => x.IdConsulta).HasColumnName("Con_IdConsulta");
            builder.Property(x => x.Descricao).HasColumnName("Ree_Descricao");
            builder.Property(x => x.DataEmissao).HasColumnName("Ree_DataEmissao");

            builder.HasOne<Consulta>()
                .WithMany(x => x.RequerimentosExame)
                .HasForeignKey(x => x.IdConsulta);

            builder.ToTable("RequerimentoExame", "Clinica");
        }
    }
}
