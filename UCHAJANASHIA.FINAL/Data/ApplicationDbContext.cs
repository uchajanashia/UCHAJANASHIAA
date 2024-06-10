using Microsoft.EntityFrameworkCore;
using UCHAJANASHIA.FINAL.Models;

namespace UCHAJANASHIA.FINAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>()
                .HasMany(cat => cat.CatToysList)
                .WithOne(toy => toy.OwnerCat)
                .HasForeignKey(toy => toy.OwnerCatID);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Cat> Cat { get; set; }
        public DbSet<Toy> Toy { get; set; }
    }
}
