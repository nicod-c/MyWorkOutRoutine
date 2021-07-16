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
    public class DiasController : Controller
    {
        private readonly MworoutineDbContext db;

        public DiasController(MworoutineDbContext dbContext)
        {
            db = dbContext;
        }


        
        public IActionResult Listado()
        {
            return View();
        }





    }
}