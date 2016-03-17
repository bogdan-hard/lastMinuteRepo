using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
-alg genetici..=> iesi afara, descopera oameni => vei da pe oameni de calitate
- aprtamentele compartimentate :2,3,4 camere..de ce?

    --frizerie, cursuri PM, administrarea afacerilor..am caracter antreprenorial
    --fete noi alin..context ..am intrat in vorba cu ele, pe strada de ce sa le evit intra in vb cu ele , nu le pot lasa
    pur si simplu sa treaca pe langa mine, ar fi pacat, pot fi niste super fete , daca as bea o bere si apoi as
    merge sa le abordez nu prea mi-ar mai pasa daca as Fii refuzat, de ce s-ar putea sa mi se intample..
    --bu
namespace gitProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //hghghjh
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}