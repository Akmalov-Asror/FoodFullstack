using Food.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Food.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options, IServiceProvider services) : base(options)
    {
        this.Services = services;
    }
    public IServiceProvider Services { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Information> Information { get; set; }
    public DbSet<Entities.Food> Foods { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration<IdentityRole>(new RoleConfiguration(Services));
    }
}