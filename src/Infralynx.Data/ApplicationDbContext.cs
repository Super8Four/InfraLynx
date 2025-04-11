using Infralynx.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infralynx.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Device> Devices { get; set; } = null!;
    public DbSet<IPAddress> IPAddresses { get; set; } = null!;
    public DbSet<Circuit> Circuits { get; set; } = null!;
    public DbSet<Site> Sites { get; set; } = null!;
    public DbSet<Rack> Racks { get; set; } = null!;
    public DbSet<Vlan> Vlans { get; set; } = null!;
    public DbSet<Provider> Providers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Add unique constraints
        builder.Entity<Device>()
            .HasIndex(d => d.Name)
            .IsUnique();

        builder.Entity<IPAddress>()
            .HasIndex(i => i.Address)
            .IsUnique();

        builder.Entity<Circuit>()
            .HasIndex(c => c.Cid)
            .IsUnique();

        builder.Entity<Site>()
            .HasIndex(s => s.Name)
            .IsUnique();

        builder.Entity<Vlan>()
            .HasIndex(v => v.VlanId)
            .IsUnique();

        builder.Entity<Provider>()
            .HasIndex(p => p.Name)
            .IsUnique();
    }
} 