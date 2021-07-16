using Microsoft.AspNetCore.Mvc;
using primerParcial.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting; // DA ACCESO A LA CARPETA WWWROOT
using System.IO; // PERMITE TRABAJAR CON ARCHIVOS, IMAGEN, ETC QUE CARGUEMOS, SUBAMOS, ETC.
using System;
using X.PagedList.Mvc.Core;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace primerParcial.Controllers
{

    public class ClientesController : Controller
    {
        private readonly IWebHostEnvironment Hosting;

        private readonly MworoutineDbContext db;

        public ClientesController(MworoutineDbContext dbContext, IWebHostEnvironment Host)
        {
            db = dbContext;
            Hosting = Host;

        }

        public Cliente EncontrarCliente(int dni)
        {
            return db.Clientes.ToList().Where(c => c.DNI == dni).FirstOrDefault();
        }

        public bool DniExistente(int dni)
        {
            foreach (var item in db.Clientes.ToList())
            {
                if (item.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }

        public int CalcularEdad(DateTime fechaNac, Cliente cliente)
        {
            int edad = DateTime.Today.Year - cliente.fechaNac.Year;

            if (cliente.fechaNac.Month > DateTime.Today.Month)
            {
                --edad;
            }

            return edad;
        }


        public void ActualizarFotoPerfil(Cliente cliente)
        {
            string carpetaFotos = Path.Combine(Hosting.WebRootPath, "imagenes");
            string nombrearchivo = cliente.Foto.FileName;
            string rutaCompleta = Path.Combine(carpetaFotos, nombrearchivo);
            cliente.Foto.CopyTo(new FileStream(rutaCompleta, FileMode.Create));
            cliente.FotoRuta = nombrearchivo;
        }

        public void FotoPerfilDefault(Cliente cliente)
        {
            cliente.FotoRuta = "perfil_default.png";
        }

        public void MantenerFotoPerfil(Cliente cliente)
        {
            var clienteAnterior = EncontrarCliente(cliente.DNI);
            var ruta = clienteAnterior.FotoRuta;
            cliente.FotoRuta = ruta;
        }

        public void fechaInsc(Cliente cliente)
        {
            var fecha = DateTime.Today;
            cliente.fechaInscripcion = fecha;
        }

        private IPagedList Paginar(List<Cliente> lista, int? pagina)
        {
            int pageSize = 3;
            int pageNumber = (pagina ?? 1);
            return lista.ToPagedList(pageNumber, pageSize);
        }

        public IActionResult Listado(string ordenpor, string campobusqueda, int? pagina)
        {
            var listaClientes = db.Clientes.ToList();
            var lista = listaClientes;

            switch (ordenpor)
            {
                case "ordenpornombre":
                    lista = listaClientes.OrderBy(x => x.Nombre).ToList<Cliente>();
                    break;
                case "ordenporapellido":
                    lista = listaClientes.OrderBy(x => x.Apellido).ToList<Cliente>();
                    break;
                case "ordenpornumero":
                    lista = listaClientes.OrderBy(x => x.DNI).ToList<Cliente>();
                    break;
                default:
                    lista = listaClientes;
                    break;
            }

            if (!string.IsNullOrEmpty(campobusqueda))
            {
                lista = listaClientes.Where(
                x => x.Nombre.ToUpper().Contains(campobusqueda.ToUpper())
                ||
                x.Apellido.ToUpper().Contains(campobusqueda.ToUpper())
                ||
                x.DNI.ToString().ToUpper().Contains(campobusqueda.ToUpper())
                ).ToList<Cliente>();
            }

            var listapaginada = Paginar(lista, pagina);

            return View(listapaginada);

        }


        public IActionResult Mostrar(int dni)
        {
            var cliente = db.Clientes
            .Include(c => c.Rutinas).Include(c => c.Objetivo).
            Where(c => c.DNI == dni).
            FirstOrDefault();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Mostrar(string volver, string dni)
        {
            if (!string.IsNullOrEmpty(volver))
            {
                return RedirectToAction("Listado");
            }

            return View();
        }


        public IActionResult Editar(int dni)
        {
            var cliente = EncontrarCliente(dni);
            ViewBag.Objetivos = db.Objetivos.ToList();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente clienteFormulario, string guardar, string cancelar)
        {

            if (!string.IsNullOrEmpty(cancelar))
            {
                return RedirectToAction("Listado");
            }

            if (!ModelState.IsValid && !string.IsNullOrEmpty(guardar))
            {
                return View();
            }


            switch (clienteFormulario.Foto)
            {
                case null:
                    // MantenerFotoPerfil(clienteFormulario);
                    FotoPerfilDefault(clienteFormulario);
                    break;
                default:
                    ActualizarFotoPerfil(clienteFormulario);
                    break;
            }

            db.Clientes.Update(clienteFormulario);
            db.SaveChanges();
            return RedirectToAction("Listado");
        }

        public IActionResult Nuevo()
        {
            ViewBag.Objetivos = db.Objetivos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Cliente clienteFormulario, string guardar, string cancelar)
        {
            fechaInsc(clienteFormulario);
            clienteFormulario.Edad = CalcularEdad(clienteFormulario.fechaNac,clienteFormulario);
            
            if (!string.IsNullOrEmpty(cancelar))
            {
                return RedirectToAction("Index", "Home");
            }

            if (DniExistente(clienteFormulario.DNI) && !string.IsNullOrEmpty(guardar))
            {
                ModelState.AddModelError("DNI", "Ya existe un cliente con ese DNI");
                return View();
            }

            if (!ModelState.IsValid && !string.IsNullOrEmpty(guardar))
            {
                return View();
            }

            switch (clienteFormulario.Foto)
            {
                case null:
                    FotoPerfilDefault(clienteFormulario);
                    break;
                default:
                    ActualizarFotoPerfil(clienteFormulario);
                    break;
            }

            db.Clientes.Add(clienteFormulario);
            db.SaveChanges();
            return RedirectToAction("Listado");

        }


        public IActionResult Borrar(int dni)
        {
            var cliente = EncontrarCliente(dni);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Listado");
        }

        public IActionResult ListadoRutinas(int dni, string volver)
        {
            if (!string.IsNullOrEmpty(volver))
            {
                return RedirectToAction("Listado");
            }

            var cliente = db.Clientes
            .Include(c => c.Rutinas).
            Where(c => c.DNI == dni).
            FirstOrDefault();
            return View(cliente);
        }

    }

}