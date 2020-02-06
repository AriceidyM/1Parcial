using Microsoft.EntityFrameworkCore;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=.\SqlExpress;Database=Parcial1Db;trusted_Connection =true"));
        }
    }
}
