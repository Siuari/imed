using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Pag_IdPagamento");
            builder.Property(x => x.IdConsulta).HasColumnName("Con_IdConsulta");
            builder.Property(x => x.IdFormaPagamento).HasColumnName("Fop_IdFormaPagamento");
            builder.Property(x => x.Valor).HasColumnName("Pag_Valor");
            builder.Property(x => x.DataPagamento).HasColumnName("Pag_DataPagamento");

            builder.HasOne(x => x.Consulta)
                .WithMany(x => x.Pagamentos)
                .HasForeignKey(x => x.IdConsulta);

            builder.HasOne(x => x.FormaPagamento)
                .WithMany(x => x.Pagamentos)
                .HasForeignKey(x => x.IdFormaPagamento);

            builder.ToTable("Pagamento", "Clinica");
        }
    }
}
