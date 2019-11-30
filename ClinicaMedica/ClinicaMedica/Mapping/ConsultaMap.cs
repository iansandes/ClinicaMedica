using ClinicaMedica.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClinicaMedica.Mapping
{
    public class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            ToTable("Consulta");

            HasKey(x => x.Id);
            Property(x => x.Paciente.Nome);
            Property(x => x.Medico.Nome);
            Property(x => x.Medico.Especialidade);
            Property(x => x.Data);
        }
    }
}