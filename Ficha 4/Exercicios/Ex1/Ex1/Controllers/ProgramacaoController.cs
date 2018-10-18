using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1.Controllers
{
    public class ProgramacaoController : Controller
    {
        // GET: Programaao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BemVindo(string texto, int quant=1)
        {
            ViewBag.Texto = texto;
            ViewBag.Quant = quant;
            return View();
        }

        public ActionResult Web()
        {
            return View();
        } 

       /* public ActionResult BemVindo()
        {
            return Content("<h1>Bem Vindo! Metodo 2!</h1>");
        }*/
    }
}