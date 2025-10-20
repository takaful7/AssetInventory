using Microsoft.EntityFrameworkCore;
using AssetInventory.Models;
using AssetInventory.Models.Entities;
using AssetInventory.Models.Histories;

namespace AssetInventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Asset> Assets { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<DeviceModel> DeviceModels { get; set; }

        public DbSet<DeviceType> DeviceTypes { get; set; }

        public DbSet<JobTitle> JobTitles { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<AssetAssignmentHistory> AssetAssignmentHistories { get; set; }

        public DbSet<AssetLocationHistory> AssetLocationHistories { get; set; }

        public DbSet<AssetStatusHistory> AssetStatusHistories { get; set; }

        public DbSet<AssetConditionHistory> AssetConditionHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var admin1 = new Admin
            {
                Id = 1,
                FullName = "Ali",
                Username = "admin",
                PasswordHash = "123456",
                Role = "Admin"
            };

            modelBuilder.Entity<Admin>().HasData(admin1);

        }
    }
}
