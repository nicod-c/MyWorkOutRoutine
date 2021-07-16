using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;


namespace primerParcial.Models
{
    public class Usuario
    {
        public Usuario(string nombre, string apellido, string email, string pass)
        {
            /* nombre = nombre;
             apellido = apellido;
             email = email;
             password = pass; */
        }

        public int UsuarioId { get; set; }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
        }

        private string email;
        public string Email
        {
            get { return email; }
        }

        private string password;
        public string Password
        {
            get { return password; }
        }
    }
}