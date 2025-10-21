using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class Location : BaseEntity
    {
        public string LocationName { get; set; }

        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
