using Microsoft.AspNetCore.Mvc;
using primerParcial.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using X.PagedList.Mvc.Core;
using X.PagedList;
using Microsoft.EntityFrameworkCore;


namespace primerParcial.Controllers
{
    public class ActividadesController : Controller
    {
        private readonly MworoutineDbContext db;

        public ActividadesController(MworoutineDbContext dbContext)
        {
            db = dbContext;
        }



        public IActionResult Borrar(int id)
        {
            var actividad = db.Actividades.ToList().Where(a => a.ActividadId == id).FirstOrDefault();
            var dia = db.Dias.ToList().Where(d => d.DiaId == actividad.DiaId).FirstOrDefault();
            var idrutina = dia.RutinaId;
            db.Actividades.Remove(actividad);
            db.SaveChanges();
            return RedirectToAction("CargarDias", "Rutinas", new { rutinaid = idrutina });
        }



    }
}