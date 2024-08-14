using Microsoft.EntityFrameworkCore;
using Refactoring_using_Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_using_Generics.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Asiento> Asientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestDatabase");
        }
    }
}
