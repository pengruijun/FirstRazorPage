using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FirstRazorPage.Models;

namespace FirstRazorPage.Data
{
    public class BakeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Database=Blogging;Server=RL-RUIJUN\MSSQLSERVER2014;uid=ruijun;pwd=;");
        }
    }
}
