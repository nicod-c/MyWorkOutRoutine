using Microsoft.AspNetCore.Mvc;
using primerParcial.Models;
using primerParcial.Models.VM;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using X.PagedList.Mvc.Core;
using X.PagedList;



namespace primerParcial.Controllers
{

    public class EjerciciosController : Controller
    {

        private readonly MworoutineDbContext db;

        public EjerciciosController(MworoutineDbContext dbContext)
        {
            db = dbContext;
        }

        private IPagedList Paginar(List<Ejercicio> lista, int? pagina)
        {
            int pageSize = 4;
            int pageNumber = (pagina ?? 1);
            return lista.ToPagedList(pageNumber, pageSize);
        }

        public IActionResult Listado(string campobusqueda, int? pagina)
        {
            var listaEjercicios = db.Ejercicios.ToList();
            var lista = listaEjercicios;

            if (!string.IsNullOrEmpty(campobusqueda))
            {
                lista = listaEjercicios.Where(
                    x => x.Nombre.ToUpper().Contains(campobusqueda.ToUpper())).ToList<Ejercicio>();
            }

            var listapaginada = Paginar(lista, pagina);

            return View(listapaginada);

        }


        public IActionResult Editar(int id)
        {
            var ejercicio = db.Ejercicios.ToList().Where(e => e.EjercicioId == id).FirstOrDefault();
            ViewBag.PartesDelCuerpo = db.PartesDelCuerpo.ToList();
            ViewBag.Musculos = db.Musculos.ToList();
            return View(ejercicio);
        }

        [HttpPost]
        public IActionResult Editar(Ejercicio ejercicioform, string guardar, string cancelar)
        {

            if (!string.IsNullOrEmpty(cancelar))
            {
                return RedirectToAction("Listado");
            }

            if (ModelState.IsValid && !string.IsNullOrEmpty(guardar))
            {
                db.Ejercicios.Update(ejercicioform);
                db.SaveChanges();
                return RedirectToAction("Listado");
            }

            return View();

        }

        public IActionResult Borrar(int id)
        {
            var ejercicio = db.Ejercicios.ToList().Where(x => x.EjercicioId == id).FirstOrDefault();
            db.Ejercicios.Remove(ejercicio);
            db.SaveChanges();
            return RedirectToAction("Listado");
        }

        public IActionResult Nuevo()
        {
            var ejercicioVM = new EjercicioVM();
            ejercicioVM.PartesDelCuerpo = db.PartesDelCuerpo.ToList();
            ejercicioVM.Musculos = db.Musculos.ToList();
            return View(ejercicioVM);
        }

        [HttpPost]
        public IActionResult Nuevo(EjercicioVM ejervmform, string guardar, string cancelar)
        {

            if (!string.IsNullOrEmpty(cancelar))
            {
                return RedirectToAction("Listado");
            }

            if (ModelState.IsValid && !string.IsNullOrEmpty(guardar))
            {
                var ejercicio = ejervmform.Ejercicio;
                db.Ejercicios.Add(ejercicio);
                db.SaveChanges();
                return RedirectToAction("Listado");
            }

            return View();
        }


    }
}