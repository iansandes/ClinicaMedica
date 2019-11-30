using System;

namespace ClinicaMedica.Domain
{
    public class Consulta
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Data { get; set; }
    }
}
