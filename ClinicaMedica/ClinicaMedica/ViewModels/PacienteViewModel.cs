using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaMedica.ViewModels
{
    public class PacienteViewModel
     {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name ="Nome Completo")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone { get; set; }
    }
}