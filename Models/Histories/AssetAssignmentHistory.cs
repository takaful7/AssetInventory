using AssetInventory.Models.Base;
using AssetInventory.Models.Entities;

namespace AssetInventory.Models.Histories
{
    public class AssetAssignmentHistory : BaseHistoryEntity
    {

        public long UserId { get; set; }

        public User User { get; set; }

    }
}
