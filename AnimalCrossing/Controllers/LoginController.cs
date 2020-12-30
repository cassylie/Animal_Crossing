using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnimalCrossing.DAL;
using AnimalCrossing.DTO;
using AnimalCrossing.Interface;
using AnimalCrossing.Controllers;
using System.Web.Mvc;


namespace AnimalCrossing.Controllers
{
    public class LoginController : Controller
    {
        private IRepository db;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Connexion(String log_username, String log_password)
        {
            LoginDTO logg = db.Authentifier(log_username, log_password);
            if (logg == null)
            {
                return HttpNotFound();
            }
            Session["Email"] = logg.email;
            Session["Pseudo"] = logg.pseudo;
            Session["ID"] = logg.id_user;
            Session["Ile"] = logg.ile;
            Session["Hemisphere"] = logg.hemisphere;
            Session["Statut"] = logg.statut;
            Session["Fruit"] = logg.fruit;
            return RedirectToAction("Index", "Home");
        }
        public LoginController()
        {

            db = new Repository();
        }



        public ActionResult Deco()
        {
            // Put user code to initialize the page here
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ShowAccueilView()
        {
            return View("Accueil");
        }

        public ActionResult ShoweveView()
        {
            return View("Evenement");
        }
    }
}