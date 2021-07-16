using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class Rutina
    {
        [Key]
        public int RutinaId { get; set; }

        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "Debe ingresar una fecha de inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaInicio { get; set; }

        [Display(Name = "Fecha de finalización")]
        [Required(ErrorMessage = "Debe ingresar una fecha de finalización")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaFin { get; set; }

        [Display(Name = "Cantidad de días por semana")]
        [Range(1, 7)]
        [Required(ErrorMessage = "Debe seleccionar la cantidad de días por semana")]
        public int cantDiasporSemana { get; set; }

        public virtual List<Dia> Dias{get;set;}
        
        public int ClienteDNI{get;set;}
        
        public virtual Cliente Cliente { get; set; }
    }
}