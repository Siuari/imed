using Clinica.Domain.Models;
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
    }
}
