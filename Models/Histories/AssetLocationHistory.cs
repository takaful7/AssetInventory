using AssetInventory.Models.Base;
using AssetInventory.Models.Entities;

namespace AssetInventory.Models.Histories
{
    public class AssetLocationHistory : BaseHistoryEntity
    {

        public long LocationId { get; set; }

        public Location Location { get; set; }
    }
}
