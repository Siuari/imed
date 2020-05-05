using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Fop_IdFormaPagamento");
            builder.Property(x => x.Descricao).HasColumnName("Fop_Descricao");

            builder.HasMany<Pagamento>()
                .WithOne(x => x.FormaPagamento)
                .HasForeignKey(x => x.IdFormaPagamento);

            builder.ToTable("FormaPagamento", "Clinica");
        }
    }
}
