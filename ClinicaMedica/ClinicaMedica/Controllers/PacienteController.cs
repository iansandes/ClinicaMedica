using ClinicaMedica.Context;
using ClinicaMedica.Domain;
using ClinicaMedica.Repositories;
using ClinicaMedica.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{
    [RoutePrefix("pacientes")]
    public class PacienteController : Controller
    {
        private ClinicaMedicaDataContext _db = new ClinicaMedicaDataContext();

        [Route("listar")]
        public ActionResult Index()
        {
            return View(_db.Pacientes.ToList());
        }

        [Route("criar")]
        public ActionResult Criar()
        {
            var paciente = new PacienteViewModel()
            {
                Nome = "",
                Idade = 0,
                Sexo = "",
                Telefone = ""
            };
            return View(paciente);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Criar(PacienteViewModel pacienteModel)
        {
            var paciente = new Paciente();
            paciente.Nome = pacienteModel.Nome;
            paciente.Idade = pacienteModel.Idade;
            paciente.Sexo = pacienteModel.Sexo;
            paciente.DataNascimento = pacienteModel.DataNascimento.Date;
            paciente.Telefone = pacienteModel.Telefone;

            _db.Pacientes.Add(paciente);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("editar")]
        public ActionResult Editar(int id)
        {
            var paciente = _db.Pacientes.Find(id);
            var model = new PacienteViewModel() 
            {
                Nome = paciente.Nome,
                Idade = paciente.Idade,
                DataNascimento = paciente.DataNascimento.Date,
                Sexo = paciente.Sexo,
                Telefone = paciente.Telefone
            };

            return View(model);
        }

        [Route("editar")]
        [HttpPost]
        public ActionResult Editar(PacienteViewModel pacienteModel)
        {
            var paciente = _db.Pacientes.Find(pacienteModel.Id);
            _db.Entry(paciente).CurrentValues.SetValues(pacienteModel);
            _db.Entry(paciente).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("deletar/id:{int}")]
        public ActionResult Deletar()
        {
            return View();
        }


    }
}