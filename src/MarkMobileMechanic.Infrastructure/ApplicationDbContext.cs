using MarkMobileMechanic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarkMobileMechanic.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<WorkOrder> WorkOrders => Set<WorkOrder>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Booking>()
            .HasIndex(b => new { b.TechnicianId, b.StartTime, b.EndTime });

        modelBuilder.Entity<Booking>()
            .Property(b => b.Status)
            .HasMaxLength(50);

        modelBuilder.Entity<Service>()
            .Property(s => s.Price)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Service>()
            .Property(s => s.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<Service>()
            .Property(s => s.Description)
            .HasMaxLength(500);

        modelBuilder.Entity<Vehicle>()
            .Property(v => v.Make)
            .HasMaxLength(200);

        modelBuilder.Entity<Vehicle>()
            .Property(v => v.Model)
            .HasMaxLength(200);

        modelBuilder.Entity<Vehicle>()
            .Property(v => v.Vin)
            .HasMaxLength(100);

        modelBuilder.Entity<WorkOrder>()
            .Property(w => w.Notes)
            .HasMaxLength(1000);
    }
}
