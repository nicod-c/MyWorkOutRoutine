using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class Dia
    {
        [Display(Name = "Dia número")]
        [Range(1, 7, ErrorMessage = "El día no puede ser mayor a 7")]
        public int Numero { get; set; }

        [Key]
        public int DiaId { get; set; }

        public virtual List<Actividad> Actividades { get; set; }
        
        public int RutinaId{get;set;}
        
        public virtual Rutina Rutina { get; set; }
    }
}