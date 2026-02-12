using Microsoft.EntityFrameworkCore;
using StageNova.Models;
using StageNova.Models.DbConfiguration;

namespace StageNova.Data
{
    public class StageNovaDbContext : DbContext
    {
        public StageNovaDbContext()
        {
        }

        public StageNovaDbContext(DbContextOptions<StageNovaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Play> Plays { get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Souvenir> Souvenirs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // UserRole (Many-to-Many)
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.RolesUsers)
                .HasForeignKey(ur => ur.RoleId);

            // Play -> Performances (One-to-Many)
            modelBuilder.Entity<Performance>()
                .HasOne(p => p.Play)
                .WithMany(pl => pl.Performances)
                .HasForeignKey(p => p.PlayId);

            // Performance -> Tickets (One-to-Many)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Performance)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PerformanceId);

            // User -> Tickets (One-to-Many)
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tickets)
                .HasForeignKey(t => t.UserId);

            // Decimal precision
            modelBuilder.Entity<Play>()
                .Property(p => p.TicketPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Ticket>()
                .Property(t => t.TotalPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Souvenir>()
                .Property(s => s.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.UnitPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}