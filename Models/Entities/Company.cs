using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }

        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
