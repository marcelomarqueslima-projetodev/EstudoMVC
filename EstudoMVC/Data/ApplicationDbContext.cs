using EstudoMVC.Mapping;
using EstudoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
