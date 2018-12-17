using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandRegister.Data
{
    public class BandRegisterDbContext : DbContext
    {
        private const string ConectionString = @"Server=.\SQLEXPRESS;Database=BandRegister;Integrated Security=True;";

        public virtual DbSet<Band> Bands { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConectionString);
        }
    }
}
