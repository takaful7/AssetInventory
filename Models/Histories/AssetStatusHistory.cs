using AssetInventory.Models.Base;
using AssetInventory.Models.Entities;

namespace AssetInventory.Models.Histories
{
    public class AssetStatusHistory : BaseHistoryEntity
    {
        public long StatusId { get; set; }

        public Status Status { get; set; }
    }
}
