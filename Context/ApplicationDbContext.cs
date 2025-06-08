using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TodoApps.Models;

namespace TodoApps.Context
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    }

