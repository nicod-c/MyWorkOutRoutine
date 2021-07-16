using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;


namespace primerParcial.Models
{
    public class Actividad
    {
        [Key]
        public int ActividadId { get; set; }

        public string Observaciones { get; set; }

        [Display(Name = "Cantidad de series")]
        [Required]
        public int cantSeries { get; set; }

        [Display(Name = "Repeticiones por serie")]
        [Required]
        public int cantRepeticiones { get; set; }

        [Display(Name = "Ejercicio")]
        public int EjercicioId { get; set; }

        public virtual Ejercicio Ejercicio { get; set; }

        public int DiaId { get; set; }
        public virtual Dia Dia { get; set; }

    }
}