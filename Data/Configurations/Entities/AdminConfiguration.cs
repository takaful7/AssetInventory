using AssetInventory.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetInventory.Data.Configurations.Entities
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            //Nama Table
            builder.ToTable("Admins");

            //PK
            builder.HasKey(a => a.Id);

            //properti wajib isi dan minimum panjang
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Username).IsRequired().HasMaxLength(12);
            builder.Property(a => a.PasswordHash).IsRequired().HasMaxLength(16);

            //properti wajib diisi only
            builder.Property(a => a.Role).IsRequired();
            builder.Property(a => a.CreatedAt).IsRequired();
        }
    }
}
