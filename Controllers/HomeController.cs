using CrudProjeto365.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProjeto365.Controllers
{
    public class HomeController : Controller
    {

        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Contato contato)
        {
            _context.Contato.Add(contato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
