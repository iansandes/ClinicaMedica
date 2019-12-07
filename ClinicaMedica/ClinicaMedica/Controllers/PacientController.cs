using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{

    [RoutePrefix("paciente")]
    public class PacienteController : Controller
    {
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

        [Route("editar/{id:int}")]
        public ActionResult Editar(int id)
        {
            return View();
        }

        [Route("deletar/{id:int}")]
        public ActionResult Deletar(int id)
        {
            return View();
        }
    }
}