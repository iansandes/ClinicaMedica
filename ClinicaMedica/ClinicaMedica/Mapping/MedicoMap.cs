using ClinicaMedica.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaMedica.Mapping
{
    public class MedicoMap : EntityTypeConfiguration<Medico>
    {
        public MedicoMap()
        {
            ToTable("Medico");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();
            Property(x => x.Idade).IsRequired();
            Property(x => x.Especialidade).IsRequired();
            Property(x => x.DataNascimento).IsRequired();
            Property(x => x.Salario).IsRequired();
            Property(x => x.Telefone).IsRequired();
        }
    }
}