using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Con_IdConsulta");
            builder.Property(x => x.IdPaciente).HasColumnName("Pac_IdPaciente");
            builder.Property(x => x.IdCobertura).HasColumnName("Cob_IdCobertura");
            builder.Property(x => x.IdHorarioAtendimento).HasColumnName("Hoa_IdHorarioAtendimento");
            builder.Property(x => x.DataConsulta).HasColumnName("Con_Data");
            builder.Property(x => x.StatusConsulta).HasColumnName("Con_StatusConsulta");
            builder.Property(x => x.ValorConsulta).HasColumnName("Con_ValorConsulta");

            builder.HasOne(x => x.Cobertura)
                .WithMany(x => x.Consultas)
                .HasForeignKey(x => x.IdCobertura);
            
            builder.HasOne(x => x.Paciente)
                .WithMany(x => x.Consultas)
                .HasForeignKey(x => x.IdPaciente);
            
            builder.HasOne(x => x.HorarioAtendimento)
                .WithMany(x => x.Consultas)
                .HasForeignKey(x => x.IdHorarioAtendimento);

            builder.HasMany(x => x.Pagamentos)
                .WithOne(x => x.Consulta)
                .HasForeignKey(x => x.IdConsulta);       
            
            builder.HasMany(x => x.ReceitasMedica)
                .WithOne(x => x.Consulta)
                .HasForeignKey(x => x.IdConsulta);    
            
            builder.HasMany(x => x.RequerimentosExame)
                .WithOne(x => x.Consulta)
                .HasForeignKey(x => x.IdConsulta);

            builder.ToTable("Consulta", "Clinica");
        }
    }
}
