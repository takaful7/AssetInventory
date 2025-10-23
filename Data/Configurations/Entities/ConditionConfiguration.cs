using AssetInventory.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetInventory.Data.Configurations.Entities
{
    public class ConditionConfiguration : IEntityTypeConfiguration<Condition>
    {
        public void Configure(EntityTypeBuilder<Condition> builder)
        {
            //Nama Table
            builder.ToTable("Conditions");

            //pk
            builder.HasKey(c => c.Id);

            //properti yang wajib diisi & punya minimal panjang
            builder.Property(c => c.ConditionName).IsRequired().HasMaxLength(20);

            //properti yang penting wajib diisi
            builder.Property(c => c.CreatedAt).IsRequired();


        }
    }
}
