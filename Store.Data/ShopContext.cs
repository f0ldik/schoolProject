using Microsoft.EntityFrameworkCore;
using Store.Core.Models.Orders;
using Store.Core.Models.Phones;

namespace Store.Data;

public  class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options)
        : base(options)
    {
    }

    public ShopContext()
    {
        
    }

    public virtual DbSet<Order> Orders { get; set; }
    //public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAdress).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Nov).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.HasMany(e => e.Items).WithOne(e => e.Order).HasForeignKey(e => e.OrderId);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Phonos");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Procesor).HasMaxLength(50);
            entity.Ignore(e => e.CameraMP);
            entity.Ignore(e => e.DisplayFullSize);
            entity.Ignore(e => e.DisplayGC);
            entity.Ignore(e => e.DisplaySize);
            entity.Ignore(e => e.Height);
            entity.Ignore(e => e.Image);
            entity.Ignore(e => e.MemorySize);
            entity.Ignore(e => e.Width);
        });

    }

}
