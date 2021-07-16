using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class Musculo
    {

        [Key]
        public int MusculoId { get; set; }

        public string Nombre { get; set; }

        public virtual List<Ejercicio> Ejercicios { get; set; }
    }

}