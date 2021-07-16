using Microsoft.AspNetCore.Mvc;
using primerParcial.Models;
using primerParcial.Models.VM;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting; // DA ACCESO A LA CARPETA WWWROOT
using System.IO; // PERMITE TRABAJAR CON ARCHIVOS, IMAGEN, ETC QUE CARGUEMOS, SUBAMOS, ETC.
using System;
using X.PagedList.Mvc.Core;
using X.PagedList;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Controllers
{

    public class RutinasController : Controller
    {

        private readonly MworoutineDbContext db;

        public RutinasController(MworoutineDbContext dbContext)
        {
            db = dbContext;
        }

        static List<int> DiasPorSemana = new List<int>{
            1,2,3,4,5,6,7
        };


        public List<Dia> CrearListaDias(Rutina rutina)
        {

            var listaDias = new List<Dia>();

            for (int i = 1; i <= rutina.cantDiasporSemana; i++)
            {
                var dia = new Dia();
                dia.Numero = i;
                dia.RutinaId = rutina.RutinaId;
                // dia.Actividades = new List<Actividad>();
                listaDias.Add(dia);
            }

            return listaDias;
        }

        public void GuardarDiasDb(List<Dia> lista)
        {

            foreach (var dia in lista)
            {
                db.Dias.Add(dia);
            }

        }


        public IActionResult Nueva(int dni)
        {
            var cliente = db.Clientes.ToList().Where(c => c.DNI == dni).FirstOrDefault();

            var rutina = new Rutina();

            rutina.Cliente = cliente;

            ViewBag.cantDiasporSemana = DiasPorSemana;

            return View(rutina);
        }


        [HttpPost]
        public IActionResult Nueva(Rutina rutinaFormulario, int dni, string cancelar, string continuar)
        {

            if (!string.IsNullOrEmpty(cancelar))
            {
                return RedirectToAction("ListadoRutinas", "Clientes", new { dni = dni });
            }

            if (ModelState.IsValid && !string.IsNullOrEmpty(continuar))
            {
                var cliente = db.Clientes.ToList().Where(c => c.DNI == dni).FirstOrDefault();
                rutinaFormulario.Cliente = cliente;
                rutinaFormulario.Dias = CrearListaDias(rutinaFormulario);
                GuardarDiasDb(rutinaFormulario.Dias);
                db.Rutinas.Add(rutinaFormulario);
                db.SaveChanges();
                return RedirectToAction("CargarDias", new { rutinaid = rutinaFormulario.RutinaId });
            }

            return View();
        }

        public IActionResult CargarDias(int rutinaid)
        {
            var rutina = db.Rutinas.Include(r => r.Dias).ThenInclude(d => d.Actividades).
            ThenInclude(a => a.Ejercicio).Include(r => r.Cliente).ToList().Where(r => r.RutinaId == rutinaid).FirstOrDefault();

            return View(rutina);
        }


        public IActionResult CargarActividad(int diaId)
        {
            var dia = db.Dias.ToList().Where(d => d.DiaId == diaId).FirstOrDefault();

            dia.Actividades = new List<Actividad>();

            var actividad = new Actividad();

            ViewBag.Ejercicios = db.Ejercicios.ToList();

            foreach (var a in dia.Actividades)
            {
                actividad.DiaId = diaId;
                dia.Actividades.Add(actividad);
            }

            return View(actividad);
        }


        [HttpPost]
        public IActionResult CargarActividad(Actividad actividadform, string volver, string guardar, string adicionar)
        {

            var dia = db.Dias.ToList().Where(d => d.DiaId == actividadform.DiaId).FirstOrDefault();

            if (ModelState.IsValid && !string.IsNullOrEmpty(guardar))
            {
                db.Actividades.Add(actividadform);
                db.SaveChanges();
                return RedirectToAction("CargarDias", new { rutinaid = dia.RutinaId });
            }

            if (!string.IsNullOrEmpty(volver))
            {
                return RedirectToAction("CargarDias", new { rutinaid = dia.RutinaId });
            }

            if (ModelState.IsValid && !string.IsNullOrEmpty(adicionar))
            {
                db.Actividades.Add(actividadform);
                db.SaveChanges();
                return RedirectToAction("CargarActividad", new { diaId = dia.DiaId });
            }

            return View();

        }


        public IActionResult Mostrar(int id)
        {
            var rutina = db.Rutinas.
            Include(r => r.Cliente).
            Include(r => r.Dias).
            ThenInclude(dia => dia.Actividades).
            ThenInclude(actividad => actividad.Ejercicio).
            ThenInclude(ejercicio => ejercicio.Musculo).
            ToList().Where(r => r.RutinaId == id).FirstOrDefault();

            return View(rutina);
        }


        public IActionResult Borrar(int id, int dni)
        {
            var rutina = db.Rutinas.Include(r => r.Dias).ThenInclude(d => d.Actividades).ToList().Where(r => r.RutinaId == id).FirstOrDefault();

            foreach (var dia in rutina.Dias)
            {
                foreach (var actividad in dia.Actividades)
                {
                    db.Actividades.Remove(actividad);
                }

                db.Dias.Remove(dia);
            }

            db.Rutinas.Remove(rutina);
            db.SaveChanges();
            return RedirectToAction("ListadoRutinas", "Clientes", new { dni = dni });
        }



    }
}
