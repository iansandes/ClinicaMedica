using ClinicaMedica.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaMedica.Mapping
{
    public class PacienteMap : EntityTypeConfiguration<Pacient>
    {
        public PacienteMap()
        {
            ToTable("Paciente");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.Idade).IsRequired();
            Property(x => x.Sexo).IsRequired();
            Property(x => x.DataNascimento).IsRequired();
            Property(x => x.Convenio).IsRequired();
            Property(x => x.Telefone).IsRequired();
        }
    }
}