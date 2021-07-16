using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class ParteDelCuerpo
    {

        [Key]
        public int ParteDelCuerpoId { get; set; }

        public string Nombre { get; set; }

        public virtual List<Musculo> Musculo { get; set; }

    }
}