using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace primerParcial.Models
{
    public class PersonalTrainer
    {
        [Key]
        public int TrainerId {get;set;}

        public string Nombre {get;set;}
        public string Apellido{get;set;}
        
        public virtual List<Cliente> Clientes{get;set;}

    }
}