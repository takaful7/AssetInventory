using AssetInventory.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetInventory.Data.Configurations.Entities
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            //Nama tabel
            builder.ToTable("Companies");

            //pk
            builder.HasKey(c => c.Id);

            //prop wajib & minimal panjang
            builder.Property(c => c.CompanyName).IsRequired().HasMaxLength(50);

            //unique
            builder.HasIndex(c => c.CompanyName).IsUnique();
        }
    }
}
