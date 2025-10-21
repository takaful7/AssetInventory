using AssetInventory.Models.Base;
using AssetInventory.Models.Entities;

namespace AssetInventory.Models.Histories
{
    public class AssetConditionHistory : BaseHistoryEntity
    {
        public long ConditionId { get; set; }

        public Condition Condition { get; set; }

        public string DetailCondition { get; set; }
    }
}
