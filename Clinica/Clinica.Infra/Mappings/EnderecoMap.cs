using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Id).HasColumnName("End_IdEndereco");
            builder.Property(x => x.Rua).HasColumnName("End_Rua ");
            builder.Property(x => x.Bairro).HasColumnName("End_Bairro");
            builder.Property(x => x.Numero).HasColumnName("End_Numero");
            builder.Property(x => x.Cep).HasColumnName("End_Cep").HasMaxLength(8).IsFixedLength();

            builder.HasMany(x => x.Pacientes)
                .WithOne(x => x.Endereco)
                .HasForeignKey(x => x.IdEndereco);

            builder.ToTable("Endereco", "Clinica");
        }
    }
}
