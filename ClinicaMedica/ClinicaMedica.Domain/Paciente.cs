using System;

namespace ClinicaMedica.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
    }
}

