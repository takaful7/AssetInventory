using AssetInventory.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetInventory.Data.Configurations.Entities
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            //Nama Table
            builder.ToTable("Assets");

            //primary key
            builder.HasKey(a => a.Id);

            //properti yang wajib diisi & punya minimal panjang 
            builder.Property(a => a.AssetNumber).IsRequired().HasMaxLength(16);
            builder.Property(a => a.SerialNumber).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Specification).IsRequired().HasMaxLength(100);

            //properti yang penting wajib diisi
            builder.Property(a => a.CreatedAt).IsRequired();

            //Relasi to Company (1:N)
            builder.HasOne(a=>a.Company).WithMany(c => c.Assets).HasForeignKey(a => a.CompanyId).OnDelete(DeleteBehavior.NoAction);
            //Relassi to DeviceModel (1:N)
            builder.HasOne(a => a.DeviceModel).WithMany(dm => dm.Assets).HasForeignKey(a => a.DeviceModelId).OnDelete(DeleteBehavior.NoAction);
            //Relasi to Location (1:N)
            builder.HasOne(a => a.Location).WithMany(l => l.Assets).HasForeignKey(a => a.LocationId).OnDelete(DeleteBehavior.NoAction);
            //Relasi to Condition (1:N)
            builder.HasOne(a => a.Condition).WithMany(c => c.Assets).HasForeignKey(a => a.LocationId).OnDelete(DeleteBehavior.NoAction);
            //Relasi to Status (1:N)
            builder.HasOne(a => a.Status).WithMany(s => s.Assets).HasForeignKey(a => a.StatusId).OnDelete(DeleteBehavior.NoAction);
            //Relasi to User (1:N)
            builder.HasOne(a => a.User).WithMany(u => u.Assets).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.NoAction);

            //Unique Index
            builder.HasIndex(a => a.AssetNumber).IsUnique();

        }
    }
}
