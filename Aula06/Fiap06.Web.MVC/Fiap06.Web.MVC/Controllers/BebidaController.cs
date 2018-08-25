using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class BebidaController : Controller
    {
        private BotecoContex _context = new BotecoContex();

        private List<Bebida> _lista = _context.Bebidas.ToList();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }


        [HttpPost]
        public ActionResult Cadastrar(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");

        }
    }
}