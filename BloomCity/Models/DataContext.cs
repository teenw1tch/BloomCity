using Microsoft.EntityFrameworkCore;

namespace BloomCity.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BloomCityDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка связей и поведения каскадных удалений

            // Настройка связи с User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany()  // Предполагаем, что у User может быть много заказов
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Заменяем Cascade на Restrict

            // Настройка связи с Address
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany()  // Предполагаем, что у Address может быть много заказов
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict); // Заменяем Cascade на Restrict

            // Настройка связи с Delivery
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Delivery)
                .WithMany()  // Предполагаем, что у Delivery может быть много заказов
                .HasForeignKey(o => o.DeliveryId)
                .OnDelete(DeleteBehavior.Restrict); // Заменяем Cascade на Restrict

            // Настройка связи с OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Используем Cascade для OrderDetails

            // Прочие настройки для других таблиц и их связей...

        }
    }
}
