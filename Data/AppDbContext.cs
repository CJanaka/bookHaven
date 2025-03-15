using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using Microsoft.EntityFrameworkCore;

namespace BookHaven.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockOrder> StockOrders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=book_haven;Uid=root;Pwd=;";
            optionsBuilder.UseMySql(connectionString, new MariaDbServerVersion(new Version(10, 4, 14)));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties())
                {
                    // Convert property names to snake_case
                    property.SetColumnName(ToSnakeCase(property.Name));
                }
            }
        }

        private string ToSnakeCase(string name)
        {
            var stringBuilder = new StringBuilder();

            foreach (var character in name)
            {
                if (char.IsUpper(character) && stringBuilder.Length > 0)
                {
                    stringBuilder.Append('_');
                }

                stringBuilder.Append(char.ToLowerInvariant(character));
            }

            return stringBuilder.ToString();
        }
    }
}
