using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

public class ToDoDbContext : DbContext
{
    private const string ConectionString = @"Server=.\SQLEXPRESS;Database=ToDoDb;Integrated Security=True;";

    public virtual DbSet<Task> Tasks { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConectionString);
    }
}

