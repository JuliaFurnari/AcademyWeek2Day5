using AcademyWeek2Day5.Entity;
using AcademyWeek2Day5.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2Day5.ADO
{
    class GameContext:DbContext
    {
        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Eroe> Eroi { get; set; }
        public DbSet<Categoria> Categorie { get; set; }
        public DbSet<Arma> Armi { get; set; }
        public DbSet<Mostro> Mostri { get; set; }

      


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		    Database=MostriVsEroi;Trusted_Connection=True;");
        }


       

    }
}
