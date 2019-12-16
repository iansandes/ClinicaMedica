using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaMedica.ViewModels
{
    public class MedicoViewModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome Completo")]
        
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Especialidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public float Salario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
    }
}