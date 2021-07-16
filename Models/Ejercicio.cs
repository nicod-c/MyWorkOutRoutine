using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class Ejercicio
    {
        [Key]
        public int EjercicioId { get; set; }

        [Required]
        [Display(Name = "Ejercicio")]
        public string Nombre { get; set; }

        [Display(Name = "Video(Link 'embed')")]
        [Url]
        public string Urlvideo { get; set; }

        [Display(Name = "Parte del cuerpo")]
        public int ParteDelCuerpoId { get; set; }
        public virtual ParteDelCuerpo ParteDelCuerpo { get; set; }

        [Display(Name = "Músculo")]
        public int MusculoId { get; set; }
        public virtual Musculo Musculo { get; set; }

        public virtual List<Actividad> Actividad { get; set; }
    }
}