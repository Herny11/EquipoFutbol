using EquipoFutbol.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol.Context
{
    public class ApplicationContext : DbContext {

        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Futbolistas> Futbolistas { get; set; }
        public DbSet<Posiciones> Posiciones { get; set; }
        public DbSet<View_Futbolistas> View_Futbolistas { get; set; }



    }
}
