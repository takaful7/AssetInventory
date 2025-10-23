using AssetInventory.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetInventory.Data.Configurations.Entities
{
    public class DeviceModelConfiguration : IEntityTypeConfiguration<DeviceModel>
    {
        public void Configure(EntityTypeBuilder<DeviceModel> builder)
        {
            //Nama tabel
            builder.ToTable("DeviceModels");

            //pk
            builder.HasKey(dm => dm.Id);

            //properti yang wajib diisi & punya minimal panjang
            builder.Property(dm => dm.Brand).IsRequired().HasMaxLength(50);
            builder.Property(dm => dm.Model).IsRequired().HasMaxLength(50);
        }
    }
}
