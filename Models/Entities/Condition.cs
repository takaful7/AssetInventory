using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class Condition : BaseEntity
    {
        public string ConditionName { get; set; }

        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
}
