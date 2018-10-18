using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using Ex1.Models;

namespace Ex1.Controllers
{
    public class DisciplinasController : Controller
    {
        // GET: Disciplinas
        public ActionResult Index()
        {
            IList<Disciplina> disciplinas = new List<Disciplina>
            {
                new Disciplina (1, "PWeb", "Disciplina pretende ..."),
                new Disciplina(2, "TWeb", "A"),
                new Disciplina(3, "TWeb2", "B"),
                new Disciplina(4, "TWeb3", "C"),

            };


            return View(disciplinas);
        }
    }
}