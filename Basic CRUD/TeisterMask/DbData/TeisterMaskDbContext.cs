using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;


namespace TeisterMask.DbData
{
    public class TeisterMaskDbContext : DbContext
    {
        
            private const string ConectionString = @"Server=.\SQLEXPRESS; Database = TiesterMaskDb;Integrated Security = true";
            public virtual DbSet<Task> Tasks { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(ConectionString);
            }
       
    }
}
