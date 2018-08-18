using _04.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Fiap.Web.MVC.Controllers
{
    public class ComidaController : Controller
    {

        // Chumbando uma lista como se fosse um bd
        private static List<Comida> _banco = new List<Comida>();


        public ActionResult Listar()
        {
            return View(_banco);
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Comida comida)
        {
            _banco.Add(comida); // Cadastra no "Banco"
            // enviar msg de sucesso para a pagina
            TempData["msg"] = "Comida cadastrada";
            // Redirect para evitar o cadastro novamente
            return RedirectToAction("Listar");
        }
    }
}