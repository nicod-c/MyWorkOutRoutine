using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;


namespace primerParcial.Models.VM
{
    public class EjercicioVM
    {
        public Ejercicio Ejercicio{get;set;}

        public List<Musculo> Musculos{get;set;}

        public List<ParteDelCuerpo> PartesDelCuerpo{get;set;}

    }
}