using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            
            return "<h1>Programação WEB</h1>";
        }

        public string BemVindo()
        {
            return "<h2>Olá</h2>";
        }
    }
}