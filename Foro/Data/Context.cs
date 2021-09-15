using Foro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Data
{
    public class Context : DbContext {
   
        public Context (DbContextOptions<Context> options): base (options)    
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<EntradaMiembro>().HasKey(em => new { em.EntradaId, em.MiembroId });
            modelBuilder.Entity<EntradaMiembro>().HasOne(em => em.Entrada).WithMany(e => e.MiembroHabilitados).HasForeignKey(em =>em.EntradaId);
            modelBuilder.Entity<EntradaMiembro>().HasOne(em => em.Miembro).WithMany(m => m.EntradasHabilitados).HasForeignKey(em => em.MiembroId);
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Miembro> Miembro { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }
        public DbSet<Reaccion> Reaccion { get; set; }
        public DbSet<EntradaMiembro> EntradasMiembros { get; set; }


    }
}
