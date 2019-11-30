using System;

namespace ClinicaMedica.Domain
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especialidade { get; set; }
        public float Salario { get; set; }
        public int Telefone { get; set; }
    }
}
