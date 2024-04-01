using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class CommerceContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Product> Products { get; set; }

        public CommerceContext(string connectionString = "Server=.\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;")
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("connectionString should not be empty.", "connectionString");

            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100);

            var products = new List<Product>()
{
    new Product { Id = 1, Name = "Criollo Chocolate", UnitPrice = 34.95m, IsFeatured = true },
    new Product { Id = 2, Name = "Arborio Rice", UnitPrice = 22.75m, IsFeatured = true },
    new Product { Id = 3, Name = "White Asparagus", UnitPrice = 39.80m, IsFeatured = true },
    new Product { Id = 4, Name = "Maldon Sea Salt", UnitPrice = 19.50m, IsFeatured = false },
    new Product { Id = 5, Name = "Gruyère cheese", UnitPrice = 48.50m, IsFeatured = true },
    new Product { Id = 6, Name = "Anchovies", UnitPrice = 18.75m, IsFeatured = true }
};

            modelBuilder.Entity<Product>()
                .HasData(products);

        }
    }
}
