using CafeteriaWeb.Entities;
using CafeteriaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeteriaWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(ClientesEnt entitad)
        {
            ClientesModel model = new ClientesModel();
            model.IniciarSesion(entitad);

            return RedirectToAction("Inicio", "Home");
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarClientes(ClientesEnt entidad)
        {

            ClientesModel model = new ClientesModel();
            model.RegistrarClientes(entidad);

            return View("Login", "Home");
        }

        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



    }
}