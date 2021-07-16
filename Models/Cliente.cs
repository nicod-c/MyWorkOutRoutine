using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;


namespace primerParcial.Models
{
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Debe ingresar un DNI")]
        [Display(Name = "Número de cliente (Dni)")]
        [Range(1, int.MaxValue, ErrorMessage = "El DNI no es válido")]
        public int DNI { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [MaxLength(15)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        [MaxLength(15)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese una fecha válida")]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaNac { get; set; }

        public int Edad {get;set;}

        [Display(Name = "Fecha de inscripción")]
        public DateTime fechaInscripcion { get; set; }

        [Range(0, 500, ErrorMessage = "El peso no puede ser mayor a 500")]
        public double Peso { get; set; }

        [Range(0, 3, ErrorMessage = "La altura no puede ser mayor a 3")]
        public double Altura { get; set; }

        public string FotoRuta { get; set; }

        [NotMapped()]
        public IFormFile Foto { get; set; }

        [Display(Name = "Objetivo")]
        public int ObjetivoId { get; set; }

        public virtual Objetivo Objetivo { get; set; }

        public virtual PersonalTrainer Entrenador { get; set; }

        public virtual List<Rutina> Rutinas { get; set; }

    }
}