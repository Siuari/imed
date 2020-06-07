using Clinica.Domain.Models;
using Clinica.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Context
{
    public class ClinicaContext : DbContext
    {
        public DbSet<Cobertura> Coberturas { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<HorarioAtendimento> HorariosAtendimento { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<ReceitaMedica> ReceitasMedica { get; set; }
        public DbSet<RequerimentoExame> RequerimentosExame { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoberturaMap());
            modelBuilder.ApplyConfiguration(new ConsultaMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EspecialidadeMap());
            modelBuilder.ApplyConfiguration(new FormaPagamentoMap());
            modelBuilder.ApplyConfiguration(new HorarioMap());
            modelBuilder.ApplyConfiguration(new HorarioAtendimentoMap());
            modelBuilder.ApplyConfiguration(new MedicoMap());
            modelBuilder.ApplyConfiguration(new PacienteMap());
            modelBuilder.ApplyConfiguration(new PagamentoMap());
            modelBuilder.ApplyConfiguration(new ReceitaMedicaMap());
            modelBuilder.ApplyConfiguration(new RequerimentoExameMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = db; Port = 5432; Database = clinicadb; User Id = postgres; Password = postgres;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
