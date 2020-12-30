using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalCrossing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult ShowExplorerView()
        {
            return View("Explorer");
        }

        public ActionResult ShowConnexionView()
        {
            return View("Connexion");
        }

        public ActionResult ShowCelebreView()
        {
            return View("Celebre");
        }

        public ActionResult ShowMAJView()
        {
            return View("MAJ");
        }
        public ActionResult ShowTransfertView()
        {
            return View("Transfert");
        }
        public ActionResult ShowInsectesView()
        {
            return View("Insectes");
        }
        public ActionResult ShowPoissonsView()
        {
            return View("poisson");
        }
        public ActionResult ShowCrustacesView()
        {
            return View("crustace");
        }
        public ActionResult ShowArtView()
        {
            return View("art");
        }
        public ActionResult ShowConditionView()
        {
            return View("condition");
        }
        public ActionResult ShowFleurView()
        {
            return View("fleur");
        }

        public ActionResult ShowIleView()
        {
            return View("ile");
        }

    }
}