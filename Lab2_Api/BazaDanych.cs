using Lab2_Api;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Api
{
    internal class Bazadanych : DbContext
    {
        public DbSet<PogodaDB> Weather { get; set; }
        public Bazadanych()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"DataSource=BazaD.db");
        }
    }
}
