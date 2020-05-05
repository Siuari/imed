﻿using Clinica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinica.Infra.Mappings
{
    public class HorarioAtendimentoMap : IEntityTypeConfiguration<HorarioAtendimento>
    {
        public void Configure(EntityTypeBuilder<HorarioAtendimento> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Hoa_IdHorarioAtendimento");
            builder.Property(x => x.IdMedico).HasColumnName("Med_IdMedico");
            builder.Property(x => x.IdHorario).HasColumnName("Hor_IdHorario");

            builder.HasOne<Medico>()
                .WithMany(x => x.HorariosAtendimento)
                .HasForeignKey(x => x.IdMedico);

            builder.HasOne<Horario>()
                .WithMany(x => x.HorariosAtendimento)
                .HasForeignKey(x => x.IdMedico);

            builder.HasMany<Consulta>()
                .WithOne(x => x.HorarioAtendimento)
                .HasForeignKey(x => x.IdHorarioAtendimento);

            builder.ToTable("HorarioAtendimento", "Clinica");
        }
    }
}