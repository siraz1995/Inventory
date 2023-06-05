using Inventory.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Areas.Identity.Data;

public class InventoryContext : IdentityDbContext<IdentityUser>
{
    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
    //public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
    //{
    //    public void Configure(EntityTypeBuilder<AppUser> builder)
    //    {
    //        builder.Property(u=>u.UserName).HasMaxLength(255);
    //    }
    //}
    public virtual DbSet<Unit> Units { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<ProductGroup> ProductGroups { get; set; }
    public virtual DbSet<ProductProfile> ProductProfiles { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }
}
