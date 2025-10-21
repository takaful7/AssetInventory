using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class Admin : BaseEntity
    {
        public long Id { get; set; }
        public string FullName { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }

    }
}
