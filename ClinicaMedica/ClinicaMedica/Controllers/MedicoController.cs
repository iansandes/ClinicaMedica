using ClinicaMedica.Context;
using ClinicaMedica.Domain;
using ClinicaMedica.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{
    [RoutePrefix("medicos")]
    public class MedicoController : Controller
    {
        private ClinicaMedicaDataContext _db = new ClinicaMedicaDataContext();
 
        [Route("listar")]
        public ActionResult Index()
        {
            return View(_db.Medicos.ToList());
        }
        [Route("criar")]
        public ActionResult Criar()
        {
            var medico = new MedicoViewModel()
            {
                Nome = "",
                Idade = 0,
                Especialidade = "",
                Salario = 0,
                Telefone = ""
            };
            return View(medico);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Criar(MedicoViewModel medicoModel)
        {
            var medico = new Medico();
            medico.Nome = medicoModel.Nome;
            medico.Idade = medicoModel.Idade;
            medico.Especialidade = medicoModel.Especialidade;
            medico.DataNascimento = medicoModel.DataNascimento.Date;
            medico.Salario = medicoModel.Salario;
            medico.Telefone = medicoModel.Telefone;

            _db.Medicos.Add(medico);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("editar")]
        public ActionResult Editar(int id)
        {
            var medico = _db.Medicos.Find(id);
            var model = new MedicoViewModel()
            {
                Nome = medico.Nome,
                Idade = medico.Idade,
                DataNascimento = medico.DataNascimento.Date,
                Especialidade = medico.Especialidade,
                Salario = medico.Salario,
                Telefone = medico.Telefone
            };

            return View(model);
        }

        [Route("editar")]
        [HttpPost]
        public ActionResult Editar(MedicoViewModel medicoModel)
        {
            var medico = _db.Medicos.Find(medicoModel.Id);
            _db.Entry(medico).CurrentValues.SetValues(medicoModel);
            _db.Entry(medico).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("deletar")]
        public ActionResult Deletar(int id)
        {
            var medico = _db.Medicos.Find(id);
            var model = new MedicoViewModel()
            {
                Nome = medico.Nome,
                Idade = medico.Idade,
                DataNascimento = medico.DataNascimento.Date,
                Especialidade = medico.Especialidade,
                Salario = medico.Salario,
                Telefone = medico.Telefone
            };

            return View(model);
        }

        [Route("deletar")]
        [HttpPost]
        public ActionResult Deletar(MedicoViewModel medicoModel)
        {
            var medico = _db.Medicos.Find(medicoModel.Id);
            _db.Medicos.Remove(medico);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}