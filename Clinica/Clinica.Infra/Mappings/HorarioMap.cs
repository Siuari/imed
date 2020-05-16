using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class HorarioMap : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Hor_IdHorario");
            builder.Property(x => x.HoraInicio).HasColumnName("Hor_HoraInicio").HasMaxLength(5);
            builder.Property(x => x.Dia).HasColumnName("Hor_Dia");

            builder.HasMany(x => x.HorariosAtendimento)
                .WithOne(x => x.Horario)
                .HasForeignKey(x => x.IdHorario);

            builder.ToTable("Horario", "Clinica");
        }
    }
}
