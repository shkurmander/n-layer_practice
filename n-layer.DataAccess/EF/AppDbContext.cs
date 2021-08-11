using Microsoft.EntityFrameworkCore;
using n_layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace n_layer.DataAccess
{
    public class AppDbContext : DbContext
    {
        private string _dbconnection;
        public DbSet<Target> Targets { get; set; }


        public AppDbContext(string dbconnection)
        {
            _dbconnection = dbconnection;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbconnection);
        }
    }
}
