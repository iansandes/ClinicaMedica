using ClinicaMedica.Domain;
using System.Data.Entity;


namespace ClinicaMedica.Context
{
    public class ClinicaMedicaDataContext : DbContext
    {
        public ClinicaMedicaDataContext() : base("ClinicaMedicaConnectionString")
        {}

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }



    }
}