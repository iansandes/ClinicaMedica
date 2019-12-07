using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{
    [RoutePrefix("medicos")]
    public class MedicoController : Controller
    {
        // GET: Medico
        [Route("listar")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("criar")]
        public ActionResult Criar()
        {
            return View();
        }

        [Route("editar/id:{int}")]
        public ActionResult Editar()
        {
            return View();
        }

        [Route("deletar/id:{int}")]
        public ActionResult Deletar()
        {
            return View();
        }
    }
}