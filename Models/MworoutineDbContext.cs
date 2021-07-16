using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace primerParcial.Models
{
    public partial class MworoutineDbContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes{get;set;}

        public virtual DbSet<Actividad> Actividades{get;set;}

        public virtual DbSet<Dia> Dias{get;set;}
        
        public virtual DbSet<Ejercicio> Ejercicios{get;set;}
        public virtual DbSet<Musculo> Musculos{get;set;}
        public virtual DbSet<Objetivo> Objetivos{get;set;}
        public virtual DbSet<ParteDelCuerpo> PartesDelCuerpo{get;set;}
        public virtual DbSet<PersonalTrainer> Entrenadores{get;set;}
        public virtual DbSet<Rutina> Rutinas{get;set;}

        public MworoutineDbContext()
        {

        }

        public MworoutineDbContext(DbContextOptions<MworoutineDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                // optionsBuilder.UseSqlServer("server=MININT-0GNP8M5\\SQLEXPRESS;Database=myworkoutroutine;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
