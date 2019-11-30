using System;

namespace ClinicaMedica.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Convenio { get; set; }
        public int Telefone { get; set; }
    }
}
