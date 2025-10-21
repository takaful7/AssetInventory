using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class Status : BaseEntity
    {
        public string StatusName { get; set; }

        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
