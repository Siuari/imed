using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Usu_IdUsuario");
            builder.Property(x => x.Login).HasColumnName("Usu_Login");
            builder.Property(x => x.Senha).HasColumnName("Usu_Senha");
            builder.Property(x => x.IdPaciente).HasColumnName("Usu_IdPaciente");

            builder.ToTable("Usuario", "Clinica");
        }
    }
}
